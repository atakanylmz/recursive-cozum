using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agaclaCoz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesaplaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int basamak = Convert.ToInt32(basamakTxt.Text);
                if (basamak <= 0)
                    MessageBox.Show("pozitif tamsayı değeri giriniz!");
                else
                {
                    dugum beyaz = new dugum("beyaz");
                    agac agacim = new agac(beyaz, basamak);
                    agacim.agacOlustur(beyaz, 1);
                    MessageBox.Show(agacim.sayac.ToString()+" tane sıralama vardır.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("yanlış alan girişi!");
            }          
        }
    }
}
