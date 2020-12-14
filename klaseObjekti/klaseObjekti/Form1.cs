using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klaseObjekti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try {
                Class1 osoba = new Class1(txtString.Text, Convert.ToInt32(txtInt.Text));
                txtIspis.Text = osoba.ToString();

                if(osoba.GodRod < 2002)
                {
                    txtIspis.AppendText("\rOsoba je punoljetna");
                }
                else
                {
                    txtIspis.AppendText("\rOsoba nije punoljetna");
                }

                }
            catch(Exception greska)
            {
                MessageBox.Show("Greška");
            }
        }
    }
}
