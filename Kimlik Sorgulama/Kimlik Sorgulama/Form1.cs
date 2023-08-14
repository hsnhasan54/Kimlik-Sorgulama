using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kimlik_Sorgulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long tc = long.Parse(textBox1.Text);
            int gunu = Convert.ToInt32(textBox4.Text);
          
            bool durum;
            try
            {
                using (idintity.KPSPublicSoapClient servis = new idintity.KPSPublicSoapClient())
                {
                    durum = servis.TCKimlikNoDogrula(tc,textBox2.Text,textBox3.Text, gunu);

                }
            }
            catch
            {

                durum = false;
            }
            MessageBox.Show(durum.ToString());
        }
    }
}
