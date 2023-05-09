using System.Diagnostics;
using System.Reflection;
using static WinFormsApp.Person;
using static System.Collections.Generic.IEnumerable<WinFormsApp.Person>;
using System.Data;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {

        private List<string> nameList = new List<string>();
        private int personId = 1;
        private string fileName = Directory.GetCurrentDirectory() + "/personen.csv";

        public Form1()
        {
            InitializeComponent();
            DisplayPersons();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        // Show list button
        {

            Label4.Text = string.Empty;
            string listText = string.Join(Environment.NewLine, nameList);
            Label4.Text += "Telefoonboek:\n" + listText.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        // Add new entry button
        {
            Person person = new Person();
            person.firstName = textBox3.Text;
            person.lastName = textBox1.Text;
            person.phone = textBox2.Text;
            //person.age = int.Parse(textBox5.Text);
            person.age = (int)numericUpDown1.Value;
            person.city = textBox7.Text;
            person.country = textBox6.Text;
            listBox1.Items.Add(person.ToString());
            listBox1.Sorted = true;

            SaveObjectToCSV(personId, person);
            personId++;
            ResetForm();

            //listBox1.Items.Add(textBox3.Text);

            //string textInput = textBox3.ToString();
            //int startIndex = textInput.IndexOf("Text:") + 5;
            //string extractedString = textInput.Substring(startIndex).Trim();
            //nameList.Add(extractedString);
            //nameList.Sort();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string searchInput = textBox4.Text.Trim();
            List<string> filteredList = nameList.Where(item => item.Contains(searchInput)).ToList();
            UpdateListBox(filteredList);
        }

        private void UpdateListBox(List<string> items)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(items.ToArray());
        }

        private void ResetForm()
        // Reset the input form
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            numericUpDown1.Value = 18;
        }

        public void SaveObjectToCSV(int personId, Person person)
        {
            string[] personDetails = { personId.ToString(), person.firstName, person.lastName, person.phone, person.age.ToString(), person.city, person.country };

            if (!File.Exists(fileName))
            {
                StreamWriter streamWriter = new StreamWriter(fileName);
                string[] header = { "id", "voornaam", "achternaam", "telefoonnummer", "leeftijd", "stad", "land" };
                streamWriter.WriteLine(string.Join(",", header));
                streamWriter.WriteLine(string.Join(",", personDetails));
                streamWriter.Close();
            }
            else
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter streamWriter = new StreamWriter(fs))
                    {
                        streamWriter.WriteLine(string.Join(",", personDetails));
                        streamWriter.Close();
                    }
                }
            }
            //streamWriter.WriteLine(person.ToString());
        }

        public void DisplayPersons()
        {
            string[] lines = File.ReadAllLines(fileName);
            string[] fields;
            fields = lines[0].Split(new char[] { ',' });

            int Cols = fields.GetLength(0);
            DataTable dt = new DataTable();

            //1st row must be column names; force lower case to ensure matching later on.
            for (int i = 0; i < Cols; i++)
                dt.Columns.Add(fields[i].ToLower(), typeof(string));
            DataRow Row;

            for (int i = 1; i < lines.GetLength(0); i++)
            {
                fields = lines[i].Split(new char[] { ',' });
                Row = dt.NewRow();
                for (int f = 0; f < Cols; f++)
                    Row[f] = fields[f];
                dt.Rows.Add(Row);
            }
            dataGrid1.DataSource = dt;
        }
    }
}