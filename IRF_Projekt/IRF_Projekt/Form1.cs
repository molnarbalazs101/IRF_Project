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
    public partial class FormÜdvözlés : Form
    {
        public FormÜdvözlés()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Adminbejelentkezés admin = new Form_Adminbejelentkezés();
            admin.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormUgyfelLogin ugyfel = new FormUgyfelLogin();
            ugyfel.ShowDialog();
        }
    }
}
