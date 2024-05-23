namespace OtelOtomasyon
{
    partial class form_MusteriGiris
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
            txtTckn = new TextBox();
            txtSifre = new TextBox();
            btnGiris = new Button();
            lable1 = new Label();
            label2 = new Label();
            btnKayit = new Button();
            SuspendLayout();
            // 
            // txtTckn
            // 
            txtTckn.Font = new Font("Segoe UI", 12F);
            txtTckn.Location = new Point(203, 129);
            txtTckn.Name = "txtTckn";
            txtTckn.Size = new Size(125, 34);
            txtTckn.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 12F);
            txtSifre.Location = new Point(203, 208);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(125, 34);
            txtSifre.TabIndex = 1;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(503, 148);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(135, 36);
            btnGiris.TabIndex = 2;
            btnGiris.Text = "Giris yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // lable1
            // 
            lable1.AutoSize = true;
            lable1.Font = new Font("Segoe UI", 13.8F);
            lable1.Location = new Point(84, 130);
            lable1.Name = "lable1";
            lable1.Size = new Size(113, 31);
            lable1.TabIndex = 3;
            lable1.Text = "Kimlik no:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(133, 209);
            label2.Name = "label2";
            label2.Size = new Size(64, 31);
            label2.TabIndex = 4;
            label2.Text = "Sifre:";
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(503, 208);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(135, 36);
            btnKayit.TabIndex = 5;
            btnKayit.Text = "Kayit ol";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // form_MusteriGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 420);
            Controls.Add(btnKayit);
            Controls.Add(label2);
            Controls.Add(lable1);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtTckn);
            Name = "form_MusteriGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giris yap";
            Load += form_MusteriGiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGiris;
        private Label lable1;
        private Label label2;
        private Button btnKayit;
        private TextBox txtTckn;
        private TextBox txtSifre;
    }
}