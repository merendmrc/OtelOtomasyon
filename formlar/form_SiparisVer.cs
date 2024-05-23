using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelOtomasyon.sınıflar;

namespace OtelOtomasyon.formlar
{
    public partial class form_SiparisVer : Form
    {
        private List<List<string>> _veriler;
        public form_SiparisVer(List<List<string>> veriler)
        {
            _veriler = veriler;
            InitializeComponent();
        }

        private void form_SiparisVer_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < _veriler.Count; i++)
            {
                comboBox1.Items.Add(_veriler[i][0]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ucret = 0;

            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    ucret = 300;
                    break;
                case 1:
                    ucret = 400;
                    break;
                case 2:
                    ucret = 500;
                    break;

                default:
                    break;
            }

            int tutar = ucret * int.Parse(textBox1.Text);
            try
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult cevap;

                cevap = MessageBox.Show("Siparisi onayliyor musunuz?", "Siparis onayi", buttons);

                if (cevap == DialogResult.Yes)
                {
                    Hesap yeni_hesap = new Hesap("Yemek siparisi", tutar);
                    yeni_hesap.Hesap_olustur(Convert.ToInt32(_veriler[comboBox1.SelectedIndex][1]));
                    MessageBox.Show("Siparisiniz alindi.");
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Siparis sirasinda hata." + ex);
                throw;
            }
        }
    }
}
