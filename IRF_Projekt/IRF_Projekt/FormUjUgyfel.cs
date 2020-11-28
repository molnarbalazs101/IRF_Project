using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Projekt
{
    public partial class FormUjUgyfel : Form
    {
        BeadandóEntities context = new BeadandóEntities();

        public FormUjUgyfel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Ugyfelek ugyfel = new Ugyfelek();
                ugyfel.Nev = txtNev.Text;
                ugyfel.Szuldat = dateTimePicker1.Value.Date;
                ugyfel.Telefon = txtTelefon.Text;
                context.Ugyfelek.Add(ugyfel);
                context.SaveChanges();

                MessageBox.Show("A regisztráció sikeresen megtörtént.");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtNev_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^(?!\s*$).+");

            if (regex.IsMatch(txtNev.Text))
            {
                e.Cancel = false;
                txtNev.BackColor = Color.LightGreen;
            }

            else
            {
                e.Cancel = true;
                txtNev.BackColor = Color.Red;
                MessageBox.Show("Kérjük adja meg a nevét!");
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^(\+36|06)(-|/)[0-9]{1,2}-[0-9]{3}-?[0-9]{3,4}$");

            if (regex.IsMatch(txtTelefon.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(txtTelefon.Text))

                    txtTelefon.BackColor = Color.LightGreen;


                else
                {
                    txtTelefon.BackColor = Color.White;
                }
            }

            else
            {
                e.Cancel = true;
                txtTelefon.BackColor = Color.Red;
                MessageBox.Show("Kérjük adjon meg egy érvényes telefonszámot!");

            }
        }
    }
}
