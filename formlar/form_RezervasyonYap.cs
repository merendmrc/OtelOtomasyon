using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelOtomasyon.sınıflar;

namespace OtelOtomasyon
{
    public partial class form_RezervasyonYap : Form
    {
        public form_RezervasyonYap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rezervasyon aH = new Rezervasyon(Convert.ToInt32(comboBox2.SelectedItem), dateTimePicker1.Text, dateTimePicker2.Text);
        }
    }
}
