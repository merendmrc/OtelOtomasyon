using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyon
{
    
    public partial class form_MusteriGiris : Form
    {
        public form_MusteriGiris()
        {
            InitializeComponent();
        }

        private void form_MusteriGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            Form kayitform = new form_MusteriKayit();
            kayitform.Show();
            this.Close();


        }
    }
}
