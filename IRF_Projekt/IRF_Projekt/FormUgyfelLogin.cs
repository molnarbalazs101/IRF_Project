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
    public partial class FormUgyfelLogin : Form
    {
        BeadandóEntities context = new BeadandóEntities();

        public FormUgyfelLogin()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Ugyfel = (from x in context.Ugyfelek
                          where x.Nev == felhnev.Text
                          select x).FirstOrDefault();

            if (Ugyfel == null)
            {
                MessageBox.Show("Nem létezik ilyen ügyfél. Kérjük regisztráljon!");
            }

            else

            {

                FormÚjFoglalás ujfoglalas = new FormÚjFoglalás();
                ujfoglalas.Show();

            }
        }
    }
}
