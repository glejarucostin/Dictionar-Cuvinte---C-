using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using LiveCharts;
using LiveCharts.Wpf;
using System.Drawing.Imaging;
using System.Windows.Media.Imaging;

namespace Proiect_GlejaruCostin
{
    public partial class DESEN_EN : Form
    {
        List<cuvEngleza> cuvEngl = new List<cuvEngleza>();
        int nrNoun ;
        int nrVerb ;
        int nrAdjective;
        int nrPronoun;
        public DESEN_EN()
        {
            InitializeComponent();
            incarcaDate();
            
        }
        private void incarcaDate()
        {
            TipEngleza tipEngl;
            StreamReader sr = new StreamReader("fisierEngl.txt");
            string linie = null;
            while ((linie = sr.ReadLine()) != null)
            {
                string cuvant = linie.Split(',')[0];
                string tip = linie.Split(',')[1];
                tipEngl = (TipEngleza)Enum.Parse(typeof(TipEngleza), tip);
                string pronuntie = linie.Split(',')[2];
                string formaPlural = linie.Split(',')[3];
                string formaUK = linie.Split(',')[4];
                string formaUS = linie.Split(',')[5];
                string limbaOrigine = linie.Split(',')[6];
                string sens = linie.Split(',')[7];
                string[] sensuri = sens.Split(' ');

                if (tip == "noun")
                    nrNoun++;
                if (tip == "adjective")
                    nrAdjective++;
                if (tip == "verb")
                    nrVerb++;
                if (tip == "pronoun")
                    nrPronoun++;

                cuvEngleza c = new cuvEngleza(cuvant, tipEngl, pronuntie, formaPlural, formaUK, formaUS, limbaOrigine, sensuri);
                cuvEngl.Add(c);
                
            }
        }




        private void DESEN_EN_Load(object sender, EventArgs e)
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            pieChart1.Series = new SeriesCollection {
            new PieSeries
            {
                Title = "VERB",
                Values = new ChartValues<double> { nrVerb },
                DataLabels = true,
                LabelPoint = labelPoint,

            },
            new PieSeries
            {
                Title = "ADJECTIVE",
                Values = new ChartValues<double> { nrAdjective },
                DataLabels = true,
                LabelPoint = labelPoint,
            },

            new PieSeries
            {
                Title = "NOUN",
                Values = new ChartValues<double> { nrNoun },
                DataLabels = true,
                LabelPoint = labelPoint,
            },
            new PieSeries
                {
                    Title = "PRONOUN",
                    Values = new ChartValues<double> {nrPronoun},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void intoarcereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Engleza f = new Engleza();
            f.Show();
        }
    }
}

