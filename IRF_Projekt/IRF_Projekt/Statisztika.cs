using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace IRF_Projekt
{
    public partial class Statisztika : Form
    {
        BeadandóEntities context = new BeadandóEntities();

        
        

        public Statisztika()
        {
            InitializeComponent();



            var eredmeny = from x in context.Foglalasok
                           group x by x.Kezdete.Month into g select new
                           {

                              Month=g.Key,
                              Count=g.Count()

                           };

            dataGridView1.DataSource = eredmeny.ToList();

            chart1.DataSource = eredmeny.ToList();

            var series = chart1.Series[0];
            series.ChartType = SeriesChartType.Column;
            series.BorderWidth = 2;

            series.XValueMember = "Month";
            series.YValueMembers = "Count";

            var legend = chart1.Legends[0];
            legend.Enabled = false;









        }

        
    }
}
