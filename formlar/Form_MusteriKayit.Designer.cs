namespace OtelOtomasyon
{
    partial class form_MusteriKayit
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
            components = new System.ComponentModel.Container();
            txtMail = new TextBox();
            txtSifre = new TextBox();
            btn_Kayit = new Button();
            errMail = new ErrorProvider(components);
            errSifre = new ErrorProvider(components);
            txtTckn = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            txtYas = new TextBox();
            txtTelefon = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Sifre = new Label();
            errAd = new ErrorProvider(components);
            errSoyad = new ErrorProvider(components);
            errTckn = new ErrorProvider(components);
            errTel = new ErrorProvider(components);
            errYas = new ErrorProvider(components);
            label7 = new Label();
            txtSifreT = new TextBox();
            errSifreT = new ErrorProvider(components);
            errorProvider1 = new ErrorProvider(components);
            btnGiris = new Button();
            ((System.ComponentModel.ISupportInitialize)errMail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errSifre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errAd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errSoyad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errTckn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errTel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errYas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errSifreT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 12F);
            txtMail.Location = new Point(217, 251);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(177, 34);
            txtMail.TabIndex = 4;
            txtMail.TextChanged += txtMail_TextChanged;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 12F);
            txtSifre.Location = new Point(217, 339);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(177, 34);
            txtSifre.TabIndex = 6;
            txtSifre.UseSystemPasswordChar = true;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // btn_Kayit
            // 
            btn_Kayit.Enabled = false;
            btn_Kayit.Location = new Point(484, 226);
            btn_Kayit.Name = "btn_Kayit";
            btn_Kayit.Size = new Size(140, 39);
            btn_Kayit.TabIndex = 2;
            btn_Kayit.Text = "Kayit Ol";
            btn_Kayit.UseVisualStyleBackColor = true;
            btn_Kayit.Click += button1_Click;
            // 
            // errMail
            // 
            errMail.ContainerControl = this;
            // 
            // errSifre
            // 
            errSifre.ContainerControl = this;
            // 
            // txtTckn
            // 
            txtTckn.Font = new Font("Segoe UI", 12F);
            txtTckn.Location = new Point(217, 163);
            txtTckn.Name = "txtTckn";
            txtTckn.Size = new Size(177, 34);
            txtTckn.TabIndex = 2;
            txtTckn.TextChanged += txtTckn_TextChanged;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 12F);
            txtSoyad.Location = new Point(217, 119);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(177, 34);
            txtSoyad.TabIndex = 1;
            txtSoyad.TextChanged += txtSoyad_TextChanged;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 12F);
            txtAd.Location = new Point(217, 75);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(177, 34);
            txtAd.TabIndex = 0;
            txtAd.TextChanged += txtAd_TextChanged;
            // 
            // txtYas
            // 
            txtYas.Font = new Font("Segoe UI", 12F);
            txtYas.Location = new Point(217, 207);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(55, 34);
            txtYas.TabIndex = 3;
            txtYas.TextChanged += txtYas_TextChanged;
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Segoe UI", 12F);
            txtTelefon.Location = new Point(217, 295);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(177, 34);
            txtTelefon.TabIndex = 5;
            txtTelefon.TextChanged += txtTelefon_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.Location = new Point(168, 78);
            label1.Name = "label1";
            label1.Size = new Size(43, 31);
            label1.TabIndex = 8;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(135, 122);
            label2.Name = "label2";
            label2.Size = new Size(76, 31);
            label2.TabIndex = 9;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(103, 166);
            label3.Name = "label3";
            label3.Size = new Size(108, 31);
            label3.TabIndex = 10;
            label3.Text = "Kimlik no";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.Location = new Point(164, 210);
            label4.Name = "label4";
            label4.Size = new Size(47, 31);
            label4.TabIndex = 11;
            label4.Text = "Yas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F);
            label5.Location = new Point(152, 254);
            label5.Name = "label5";
            label5.Size = new Size(59, 31);
            label5.TabIndex = 12;
            label5.Text = "Mail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F);
            label6.Location = new Point(133, 298);
            label6.Name = "label6";
            label6.Size = new Size(78, 31);
            label6.TabIndex = 13;
            label6.Text = "Tel No";
            // 
            // Sifre
            // 
            Sifre.AutoSize = true;
            Sifre.Font = new Font("Segoe UI", 13.8F);
            Sifre.Location = new Point(152, 342);
            Sifre.Name = "Sifre";
            Sifre.Size = new Size(59, 31);
            Sifre.TabIndex = 14;
            Sifre.Text = "Sifre";
            // 
            // errAd
            // 
            errAd.ContainerControl = this;
            // 
            // errSoyad
            // 
            errSoyad.ContainerControl = this;
            // 
            // errTckn
            // 
            errTckn.ContainerControl = this;
            // 
            // errTel
            // 
            errTel.ContainerControl = this;
            // 
            // errYas
            // 
            errYas.ContainerControl = this;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F);
            label7.Location = new Point(87, 386);
            label7.Name = "label7";
            label7.Size = new Size(124, 31);
            label7.TabIndex = 16;
            label7.Text = "Sifre tekrar";
            // 
            // txtSifreT
            // 
            txtSifreT.Font = new Font("Segoe UI", 12F);
            txtSifreT.Location = new Point(217, 383);
            txtSifreT.Name = "txtSifreT";
            txtSifreT.Size = new Size(177, 34);
            txtSifreT.TabIndex = 15;
            txtSifreT.UseSystemPasswordChar = true;
            txtSifreT.TextChanged += textBox1_TextChanged;
            // 
            // errSifreT
            // 
            errSifreT.ContainerControl = this;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(484, 271);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(140, 39);
            btnGiris.TabIndex = 17;
            btnGiris.Text = "Giris yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // form_MusteriKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 514);
            Controls.Add(btnGiris);
            Controls.Add(label7);
            Controls.Add(txtSifreT);
            Controls.Add(Sifre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTelefon);
            Controls.Add(txtYas);
            Controls.Add(txtAd);
            Controls.Add(txtSoyad);
            Controls.Add(txtTckn);
            Controls.Add(btn_Kayit);
            Controls.Add(txtSifre);
            Controls.Add(txtMail);
            Name = "form_MusteriKayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayit ol";
            ((System.ComponentModel.ISupportInitialize)errMail).EndInit();
            ((System.ComponentModel.ISupportInitialize)errSifre).EndInit();
            ((System.ComponentModel.ISupportInitialize)errAd).EndInit();
            ((System.ComponentModel.ISupportInitialize)errSoyad).EndInit();
            ((System.ComponentModel.ISupportInitialize)errTckn).EndInit();
            ((System.ComponentModel.ISupportInitialize)errTel).EndInit();
            ((System.ComponentModel.ISupportInitialize)errYas).EndInit();
            ((System.ComponentModel.ISupportInitialize)errSifreT).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMail;
        private TextBox txtSifre;
        private Button btn_Kayit;
        private ErrorProvider errMail;
        private ErrorProvider errSifre;
        private TextBox txtYas;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtTckn;
        private Label Sifre;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTelefon;
        private ErrorProvider errAd;
        private ErrorProvider errSoyad;
        private ErrorProvider errTckn;
        private ErrorProvider errTel;
        private ErrorProvider errYas;
        private Label label7;
        private TextBox txtSifreT;
        private ErrorProvider errSifreT;
        private ErrorProvider errorProvider1;
        private Button btnGiris;
    }
}
