using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Projekt
{
    public partial class Form_nyereményjáték : Form
    {
        public Form_nyereményjáték()
        {
            

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int Number = rnd.Next(0, 20);
            

            if (Number > 0 & Number < 10)
            {
                
                MessageBox.Show($"Gratulálunk Ön nyert!1 napra ingyen elvihető autó sorszáma: {Number.ToString()}");
            }
            else
            {
                
                MessageBox.Show($"Sajnáljuk Ön most nem nyert! Az Ön számára kisorsolt szám a következő volt: {Number.ToString()}");
            }

            
           
        }
    }
}
