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
using System.Runtime.Serialization.Formatters.Binary;
using System.Data.OleDb;
using System.Drawing.Printing;

namespace Proiect_GlejaruCostin
{
    public partial class Engleza : Form
    {
        List<cuvEngleza> cuvinte = new List<cuvEngleza>();
        public Engleza()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbWord.Text == "")
            {
                errorProvider1.SetError(tbWord, " Please enter a word ");
            }
            else
            {
                try
                {
                    TipEngleza typ;
                    string word = tbWord.Text;
                    string type = cbType.Text;
                    string pronuncion = tbPronuntie.Text;
                    string forma = tbPluralForm.Text;
                    string uk = tbUK.Text;
                    string us = tbUS.Text;
                    string origin = tbOrigine.Text;
                    string[] exp = new String[] { tbExplicatii.Text };


                    try
                    {
                        typ = (TipEngleza)Enum.Parse(typeof(TipEngleza), type);
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Failed");
                        Console.WriteLine(ex.Message);
                        typ = TipEngleza.unspecified;
                    }

                    cuvEngleza c = new cuvEngleza(word, typ, pronuncion, forma, uk, us, origin, exp);

                    MessageBox.Show(c.ToString());
                    cuvinte.Add(c);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbWord.Clear();
                    cbType.Text = "";
                    tbPronuntie.Clear();
                    tbPluralForm.Clear();
                    tbUK.Clear();
                    tbUS.Clear();
                    tbOrigine.Clear();
                    tbExplicatii.Clear();
                }
            }

        }


        

        private void serializToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(tbAfisare.Text);
                sw.Close();
                tbAfisare.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (cuvEngleza c in cuvinte)
                tbAfisare.Text += c.ToString() + Environment.NewLine;

        }

        private void principalMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main f3 = new Main();
            f3.Show();
        }

        private void tbAfisare_TextChanged(object sender, EventArgs e)
        {
            tbAfisare.ScrollBars = ScrollBars.Both;
            tbAfisare.WordWrap = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            VizualizareEN f = new VizualizareEN();
            f.Show();
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, tbAfisare.Text);
            fs.Close();
            tbAfisare.Clear();
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            tbAfisare.Text = (string)bf.Deserialize(fs);
            fs.Close();
        }

        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.AppendText("fisierEngl.txt");
            foreach(cuvEngleza c in cuvinte)
            {
                sw.Write(c.CuvEngl);
                sw.Write(",");
                sw.Write(c.tipulCuvantului);
                sw.Write(",");
                sw.Write(c.Pronuntie);
                sw.Write(",");
                sw.Write(c.FormaPlural);
                sw.Write(",");
                sw.Write(c.FormaUK);
                sw.Write(",");
                sw.Write(c.FormaUS);
                sw.Write(",");
                sw.Write(c.OrigineE);
                sw.Write(",");
                string result = string.Join(",", c.Explicatie);
                sw.Write(result);
                sw.WriteLine();

            }
            sw.Close(); 
        }

        private void bazeDeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            cuvEnglezaBD f = new cuvEnglezaBD();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = cuvengleza.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conexiune;

                cmd.CommandText = "SELECT MAX(cod) FROM cuvengleza";
                int cod = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.CommandText = "INSERT INTO cuvengleza VALUES(?,?,?,?,?,?,?,?,?)";
                cmd.Parameters.Add("@Cod", OleDbType.Integer).Value = cod + 1;
                cmd.Parameters.AddWithValue("@Cuvant", this.tbWord.Text);
                cmd.Parameters.AddWithValue("@Tip", this.cbType.Text);
                cmd.Parameters.AddWithValue("@Pronuntie", this.tbPronuntie.Text);
                cmd.Parameters.AddWithValue("@FormaPlural", this.tbPluralForm.Text);
                cmd.Parameters.AddWithValue("@FormaUK", this.tbUK.Text);
                cmd.Parameters.AddWithValue("@FormaUS", this.tbUS.Text);
                cmd.Parameters.AddWithValue("@Origine", this.tbOrigine.Text);
                cmd.Parameters.AddWithValue("@Explicatii", this.tbExplicatii.Text);
                cmd.ExecuteNonQuery();

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

        private void desenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DESEN_EN f = new DESEN_EN();
            f.Show();
        }
    }
}
