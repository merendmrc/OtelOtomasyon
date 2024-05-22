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
            dateGiris = new DateTimePicker();
            dateBitis = new DateTimePicker();
            cmbOda_no = new ComboBox();
            btnRezervasyonYap = new Button();
            checkBox1 = new CheckBox();
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
            // dateGiris
            // 
            dateGiris.CustomFormat = "yyyy-MM-dd";
            dateGiris.Format = DateTimePickerFormat.Custom;
            dateGiris.Location = new Point(287, 111);
            dateGiris.Name = "dateGiris";
            dateGiris.Size = new Size(200, 27);
            dateGiris.TabIndex = 6;
            dateGiris.ValueChanged += dateGiris_ValueChanged_1;
            // 
            // dateBitis
            // 
            dateBitis.CustomFormat = "yyyy-MM-dd";
            dateBitis.Format = DateTimePickerFormat.Custom;
            dateBitis.Location = new Point(287, 171);
            dateBitis.Name = "dateBitis";
            dateBitis.Size = new Size(200, 27);
            dateBitis.TabIndex = 7;
            // 
            // cmbOda_no
            // 
            cmbOda_no.FormattingEnabled = true;
            cmbOda_no.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            cmbOda_no.Location = new Point(287, 236);
            cmbOda_no.Name = "cmbOda_no";
            cmbOda_no.Size = new Size(151, 28);
            cmbOda_no.TabIndex = 8;
            cmbOda_no.DropDown += cmbOda_no_DropDown;
            // 
            // btnRezervasyonYap
            // 
            btnRezervasyonYap.Location = new Point(625, 199);
            btnRezervasyonYap.Name = "btnRezervasyonYap";
            btnRezervasyonYap.Size = new Size(94, 29);
            btnRezervasyonYap.TabIndex = 9;
            btnRezervasyonYap.Text = "button2";
            btnRezervasyonYap.UseVisualStyleBackColor = true;
            btnRezervasyonYap.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(514, 116);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(78, 24);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "gecmis";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // form_RezervasyonYap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 414);
            Controls.Add(checkBox1);
            Controls.Add(btnRezervasyonYap);
            Controls.Add(cmbOda_no);
            Controls.Add(dateBitis);
            Controls.Add(dateGiris);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "form_RezervasyonYap";
            Text = "Form1";
            Load += form_RezervasyonYap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private DateTimePicker dateGiris;
        private DateTimePicker dateBitis;
        private ComboBox cmbOda_no;
        private Button btnRezervasyonYap;
        private CheckBox checkBox1;
    }
}