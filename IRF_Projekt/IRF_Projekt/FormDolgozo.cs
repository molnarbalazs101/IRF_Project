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
    public partial class FormDolgozo : Form
    {
        public FormDolgozo()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormUjUgyfel ujugyfel =new FormUjUgyfel();
            ujugyfel.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucFoglalasok ucfogl = new ucFoglalasok();
            panel1.Controls.Clear();
            panel1.Controls.Add(ucfogl);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Statisztika stat = new Statisztika();
            stat.ShowDialog();
        }
    }
}
