using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proiect_GlejaruCostin
{
    public partial class AdverbDB : Form
    {
        string connString;
        public AdverbDB()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Adverb.accdb";

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            this.Close();
            Adverb f = new Adverb();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM adverb";

                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["cuvant"].ToString());
                    itm.SubItems.Add(reader["tip"].ToString());
                    itm.SubItems.Add(reader["categorie"].ToString());
                    itm.SubItems.Add(reader["grad_comparatie"].ToString());
                    itm.SubItems.Add(reader["context"].ToString());
                    itm.SubItems.Add(reader["functie"].ToString());
                    itm.SubItems.Add(reader["pronuntie"].ToString());
                    itm.SubItems.Add(reader["regionalisme"].ToString());
                    itm.SubItems.Add(reader["origine"].ToString());
                    itm.SubItems.Add(reader["explicatii"].ToString());

                    listView1.Items.Add(itm);


                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void intoarcereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Adverb f = new Adverb();
            f.Show();
        }
    }
}
