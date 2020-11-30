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
            int Number = rnd.Next(0, 10);
            MessageBox.Show(Number.ToString());

            if (Number > 0 & Number < 10)
            {
                MessageBox.Show("Gratulálunk Ön nyert!");
            }
            else
            {
                MessageBox.Show("Sajnáljuk most nem nyert!");
            }

            
           
        }
    }
}
