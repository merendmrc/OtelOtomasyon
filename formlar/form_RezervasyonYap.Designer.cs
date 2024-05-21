namespace OtelOtomasyon
{
    partial class form_RezervasyonYap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            comboBox2 = new ComboBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 42);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "Oda türü seçiniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 116);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 1;
            label2.Text = "Giris tarihi seciniz:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 176);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 2;
            label3.Text = "Cikis tarihi seciniz:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 244);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 3;
            label4.Text = "Oda seciniz:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tek kisilik", "Cift kisilik", "Aile" });
            comboBox1.Location = new Point(287, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(287, 111);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(287, 171);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 27);
            dateTimePicker2.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox2.Location = new Point(287, 236);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(603, 167);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // form_RezervasyonYap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 414);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "form_RezervasyonYap";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox2;
        private Button button2;
    }
}