using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_GlejaruCostin
{
    public partial class RomanaOF : Form
    {
        public RomanaOF()
        {
            InitializeComponent();
        }

        private void btnSubstantiv_Click(object sender, EventArgs e)
        {
            Substantiv f = new Substantiv();
            f.Show();
        }

        private void btnAdverb_Click(object sender, EventArgs e)
        {
            Adverb f = new Adverb();
            f.Show();
        }

        private void btnAdjectiv_Click(object sender, EventArgs e)
        {
            Adjectiv f = new Adjectiv();
            f.Show();
        }

        private void btnPronume_Click(object sender, EventArgs e)
        {
            Pronume f = new Pronume();
            f.Show();
        }

        private void btnVerb_Click(object sender, EventArgs e)
        {
            Verb f = new Verb();
            f.Show();
        }

        private void meniuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main f3 = new Main();
            f3.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void intoarcereInMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main f = new Main();
            f.Show();
        }

        private void schimbareCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                contextMenuStrip1.SourceControl.BackColor = dialog.Color;

        }

        private void schimbareFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                contextMenuStrip1.SourceControl.Font = dialog.Font;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.Close();
            VizualizareRO f = new VizualizareRO();
            f.Show();

        }
    }
}
