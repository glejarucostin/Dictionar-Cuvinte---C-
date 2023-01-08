using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proiect_GlejaruCostin
{
    public partial class VerbDB : Form
    {
        string connString;
        public VerbDB()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Verb.accdb";
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
                comanda.CommandText = "SELECT * FROM verb";

                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["cuvant"].ToString());
                    itm.SubItems.Add(reader["valenta"].ToString());
                    itm.SubItems.Add(reader["conjugare"].ToString());
                    itm.SubItems.Add(reader["tip"].ToString());
                    itm.SubItems.Add(reader["provenienta"].ToString());
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
            Verb f = new Verb();
            f.Show();
        }
    }
}
