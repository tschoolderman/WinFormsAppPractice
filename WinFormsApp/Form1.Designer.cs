namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            button2 = new Button();
            listBox1 = new ListBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            dataGrid1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.System;
            button1.ForeColor = Color.DarkGray;
            button1.Location = new Point(147, 266);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Show list";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Location = new Point(147, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.Location = new Point(147, 137);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.WhiteSmoke;
            textBox3.Location = new Point(147, 79);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(192, 23);
            textBox3.TabIndex = 3;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(69, 111);
            Label1.Name = "Label1";
            Label1.Size = new Size(72, 15);
            Label1.TabIndex = 4;
            Label1.Text = "Achternaam";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(43, 140);
            Label2.Name = "Label2";
            Label2.Size = new Size(98, 15);
            Label2.TabIndex = 5;
            Label2.Text = "Telefoonnummer";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(80, 82);
            Label3.Name = "Label3";
            Label3.Size = new Size(61, 15);
            Label3.TabIndex = 6;
            Label3.Text = "Voornaam";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(147, 320);
            Label4.Name = "Label4";
            Label4.Size = new Size(78, 15);
            Label4.TabIndex = 7;
            Label4.Text = "Telefoonboek";
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(240, 266);
            button2.Name = "button2";
            button2.Size = new Size(99, 23);
            button2.TabIndex = 8;
            button2.Text = "Add new entry";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Silver;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(367, 79);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(905, 154);
            listBox1.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.WhiteSmoke;
            textBox4.Location = new Point(556, 25);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(217, 23);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(508, 28);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 11;
            label5.Text = "Search";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(95, 169);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 17;
            label6.Text = "Leeftijd";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(108, 227);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 16;
            label7.Text = "Land";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(71, 198);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 15;
            label8.Text = "Woonplaats";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.WhiteSmoke;
            textBox6.Location = new Point(147, 224);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(192, 23);
            textBox6.TabIndex = 13;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.WhiteSmoke;
            textBox7.Location = new Point(147, 195);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(192, 23);
            textBox7.TabIndex = 12;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.WhiteSmoke;
            numericUpDown1.Location = new Point(147, 166);
            numericUpDown1.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(41, 23);
            numericUpDown1.TabIndex = 18;
            numericUpDown1.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // dataGrid1
            // 
            dataGrid1.BackgroundColor = Color.Silver;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Silver;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGrid1.Location = new Point(367, 266);
            dataGrid1.Name = "dataGrid1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGrid1.RowTemplate.Height = 25;
            dataGrid1.Size = new Size(905, 409);
            dataGrid1.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1284, 761);
            Controls.Add(dataGrid1);
            Controls.Add(numericUpDown1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label Label1;
        private Label Label2;
        private Label Label3;
        private Label Label4;
        private Button button2;
        private ListBox listBox1;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox6;
        private TextBox textBox7;
        private NumericUpDown numericUpDown1;
        private DataGridView dataGrid1;
    }
}