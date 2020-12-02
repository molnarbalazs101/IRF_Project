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
            MessageBox.Show(Number.ToString());

            if (Number > 0 & Number < 10)
            {
                MessageBox.Show(  $"{rnd.Next(27)}Gratulálunk Ön nyert!");
            }
            else
            {
                MessageBox.Show(string.Format("Sajnáljuk most nem nyert!{0},",13));
            }

            
           
        }
    }
}
