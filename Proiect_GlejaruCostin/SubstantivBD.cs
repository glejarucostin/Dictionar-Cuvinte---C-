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
using System.Drawing.Printing;

namespace Proiect_GlejaruCostin
{
    
    public partial class SubstantivBD : Form
    {
        string connString;
        Color culoare = Color.Blue;
        Font font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
        public SubstantivBD()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Substantiv1.accdb";

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
                comanda.CommandText = "SELECT * FROM substantiv";

                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["cuvant"].ToString());
                    itm.SubItems.Add(reader["gen"].ToString());
                    itm.SubItems.Add(reader["clasificare"].ToString());
                    itm.SubItems.Add(reader["numar"].ToString());
                    itm.SubItems.Add(reader["declinare"].ToString());
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

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem list in listView1.Items)
                if (list.Checked)
                    list.Remove();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //OleDbConnection conexiune = new OleDbConnection(connString);

            //try
            //{
            //    conexiune.Open();
                
            //}
            //catch(Exception )
        }

        private void intoarcereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Substantiv f = new Substantiv();
            f.Show();
        }
    }
}
