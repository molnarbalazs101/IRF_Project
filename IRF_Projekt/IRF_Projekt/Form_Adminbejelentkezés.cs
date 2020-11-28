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
    public partial class Form_Adminbejelentkezés : Form
    {
        public Form_Adminbejelentkezés()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jelszo.Text == "password123" & felhnev.Text == "admin1")
            {
                FormDolgozo d = new FormDolgozo();
                d.ShowDialog();
            }

            else
            {
                MessageBox.Show("Helytelen felhasználónevet vagy jelszót adott meg! Kérjük próbálja újra!");
            }
        }
    }
}
