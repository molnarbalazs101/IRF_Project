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
    public partial class AdottUgyfelFoglalásai : Form
    {
        BeadandóEntities context = new BeadandóEntities();
        Ugyfelek BejelentkezettUser;

        public AdottUgyfelFoglalásai(Ugyfelek BejelentkezettUser)
        {
            InitializeComponent();

            this.BejelentkezettUser = BejelentkezettUser;

            label1.Text = BejelentkezettUser.Nev;

            var FoglalasokListazasa = from x in context.Foglalasok
                                      where x.UgyfelekFK == BejelentkezettUser.UgyfelekID
                                      select new
                                      {
                                          x.Kezdete,
                                          x.Vege,
                                          x.Gepjarmu.Rendszam,
                                          x.Gepjarmu.Szin,
                                          x.Gepjarmu.TipusAr.Ar1napra

                                      };

           dataGridView1.DataSource = FoglalasokListazasa.ToList();
        }
    }
}
