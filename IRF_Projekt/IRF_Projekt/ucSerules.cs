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
    public partial class ucSerules : UserControl
    {
        BeadandóEntities context = new BeadandóEntities();

        public ucSerules()
        {
            InitializeComponent();

            RendszamListazas();
        }

        private void RendszamListazas()
        {
            var lista = from x in context.Gepjarmu
                        where x.Rendszam.Contains(textBox1.Text)
                        select x;

            listBox1.DataSource = lista.ToList();
            listBox1.DisplayMember = "Rendszam";

        }

        private void Listazas()
        {
            var lista = from x in context.Serulesek
                        where x.GepjarmuFK == ((Gepjarmu)listBox1.SelectedItem).gepjarmuSK
                        select new
                        {
                            x.Helye,
                            x.Tipusa,
                            x.SerulesSK

                        };

           
            dataGridView1.DataSource = lista.ToList();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            RendszamListazas();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listazas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Serulesek serules = new Serulesek();
            serules.GepjarmuFK = ((Gepjarmu)listBox1.SelectedItem).gepjarmuSK;
            serules.Helye = textBox2.Text;
            serules.Tipusa = textBox3.Text;

            context.Serulesek.Add(serules);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            Listazas();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            dynamic aktuális = bindingSource1.Current;
            int rid = aktuális.SerulesSK;

            var törlendő = (from x in context.Serulesek
                            where x.SerulesSK == rid
                            select x).FirstOrDefault();

            if (törlendő == null) return;

            context.Serulesek.Remove(törlendő);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }

            Listazas();
        }
    }
}
