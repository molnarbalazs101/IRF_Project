using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Projekt
{
    public partial class FormÚjFoglalás : Form
    {
        BeadandóEntities context = new BeadandóEntities();

    

        Ugyfelek BejelentkezettUser;

        public FormÚjFoglalás(Ugyfelek BejelentkezettUser)
        {
            InitializeComponent();

            

            this.BejelentkezettUser = BejelentkezettUser;
            label2.Text = BejelentkezettUser.Nev;

            nyeremenyCheck();

            var AutókListázása = from x in context.Gepjarmu

                                 select new
                                 {
                                     x.gepjarmuSK,
                                     x.Rendszam,
                                     x.Szin,
                                     x.TipusAr.Ar1napra,

                                 };



            context.Gepjarmu.Load();

            dataGridView1.DataSource = AutókListázása.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Foglalasok foglalas = new Foglalasok();


                foglalas.UgyfelekFK = BejelentkezettUser.UgyfelekID;


                int kivalasztottelem = (int)dataGridView1.SelectedCells[0].Value;
                foglalas.GepjarmuFK = kivalasztottelem;

                foglalas.Kezdete = dateTimePicker1.Value.Date;
                foglalas.Vege = dateTimePicker2.Value.Date;
                context.Foglalasok.Add(foglalas);
                context.SaveChanges();

                MessageBox.Show("A foglalás sikeresen megtörtént");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            dataGridView1.Refresh();

            nyeremenyCheck();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            AdottUgyfelFoglalásai foglalas = new AdottUgyfelFoglalásai(BejelentkezettUser);
            foglalas.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_nyereményjáték nyeremeny = new Form_nyereményjáték();
            nyeremeny.Show();



            


        }

        private void nyeremenyCheck()
        {
            var foglalasszam = (from x in context.Foglalasok
                        where x.UgyfelekFK == BejelentkezettUser.UgyfelekID
                        select x.FoglalasokSK).Count();

            if (foglalasszam > 5)
            {
                button3.Visible = true;
            }
            else
            {

                button3.Visible = false;

            }
            




        }
        
    }

    
}
