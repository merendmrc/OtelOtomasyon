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
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // btnRezervasyonYap
            // 
            btnRezervasyonYap.Location = new Point(99, 102);
            btnRezervasyonYap.Name = "btnRezervasyonYap";
            btnRezervasyonYap.Size = new Size(226, 49);
            btnRezervasyonYap.TabIndex = 0;
            btnRezervasyonYap.Text = "Rezervasyon yap";
            btnRezervasyonYap.UseVisualStyleBackColor = true;
            btnRezervasyonYap.Click += btnRezervasyonYap_Click;
            // 
            // button1
            // 
            button1.Location = new Point(99, 192);
            button1.Name = "button1";
            button1.Size = new Size(226, 46);
            button1.TabIndex = 1;
            button1.Text = "Rezervasyonlarım";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(99, 275);
            button2.Name = "button2";
            button2.Size = new Size(226, 49);
            button2.TabIndex = 2;
            button2.Text = "Sipariş Ver";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(99, 356);
            button3.Name = "button3";
            button3.Size = new Size(226, 49);
            button3.TabIndex = 3;
            button3.Text = "Aktif Hesap";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(176, 33);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // button4
            // 
            button4.Location = new Point(99, 433);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(231, 433);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 6;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Musteri_anasayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 513);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
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
        private Button button4;
        private Button button5;
    }
}