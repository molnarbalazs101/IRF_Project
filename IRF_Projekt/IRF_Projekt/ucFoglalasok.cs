using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Projekt
{
    public partial class ucFoglalasok : UserControl
    {
        BeadandóEntities context = new BeadandóEntities();

        public ucFoglalasok()
        {
            InitializeComponent();

            UgyfelekListazas();
        }

        private void UgyfelekListazas()
        {
            var lista = from x in context.Ugyfelek
                        where x.Nev.Contains(textBox1.Text)
                        select x;
            listBox1.DataSource = lista.ToList();
            listBox1.DisplayMember = "Nev";


        }


        private void listázás()
        {
            var lista = from x in context.Foglalasok
                        where x.UgyfelekFK == ((Ugyfelek)listBox1.SelectedItem).UgyfelekID
                        select new
                        {
                            x.Ugyfelek.Nev,
                            x.Ugyfelek.Szuldat,

                            x.Kezdete,
                            x.Vege,
                            x.Gepjarmu.Rendszam,
                            x.Gepjarmu.TipusAr.Ar1napra,

                        };
            dataGridView1.DataSource = lista.ToList();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UgyfelekListazas();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listázás();
        }
    }
}
