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

                MessageBox.Show("A foglalás sikeresen megörtént");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            dataGridView1.Refresh();
        }
    }
}
