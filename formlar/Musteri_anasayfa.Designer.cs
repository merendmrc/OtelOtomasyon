namespace OtelOtomasyon
{
    partial class Musteri_anasayfa
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
            btnRezervasyonYap = new Button();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            btnGiris = new Button();
            btnCikis = new Button();
            SuspendLayout();
            // 
            // btnRezervasyonYap
            // 
            btnRezervasyonYap.Location = new Point(107, 181);
            btnRezervasyonYap.Name = "btnRezervasyonYap";
            btnRezervasyonYap.Size = new Size(226, 49);
            btnRezervasyonYap.TabIndex = 0;
            btnRezervasyonYap.Text = "Rezervasyon yap";
            btnRezervasyonYap.UseVisualStyleBackColor = true;
            btnRezervasyonYap.Click += btnRezervasyonYap_Click;
            // 
            // button1
            // 
            button1.Location = new Point(107, 271);
            button1.Name = "button1";
            button1.Size = new Size(226, 46);
            button1.TabIndex = 1;
            button1.Text = "Rezervasyonlarım";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(107, 354);
            button2.Name = "button2";
            button2.Size = new Size(226, 49);
            button2.TabIndex = 2;
            button2.Text = "Sipariş Ver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(66, 57);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(310, 34);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(94, 29);
            btnGiris.TabIndex = 5;
            btnGiris.Text = "Giris Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += button4_Click;
            // 
            // btnCikis
            // 
            btnCikis.Enabled = false;
            btnCikis.Location = new Point(310, 69);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(94, 29);
            btnCikis.TabIndex = 6;
            btnCikis.Text = "Cikis Yap";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += button5_Click;
            // 
            // Musteri_anasayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 483);
            Controls.Add(btnCikis);
            Controls.Add(btnGiris);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnRezervasyonYap);
            Name = "Musteri_anasayfa";
            Text = "Musteri_anasayfa";
            Load += Musteri_anasayfa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRezervasyonYap;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button btnGiris;
        private Button btnCikis;
    }
}