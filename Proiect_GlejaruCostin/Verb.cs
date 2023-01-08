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

namespace Proiect_GlejaruCostin
{
    public partial class Verb : Form
    {
        List<verb1> ver = new List<verb1>();
        public Verb()
        {
            InitializeComponent();
        }


        private void intoarcereaInMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            RomanaOF f = new RomanaOF();
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tbAfisare_TextChanged(object sender, EventArgs e)
        {
            tbAfisare.ScrollBars = ScrollBars.Both;
            tbAfisare.WordWrap = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbCuvant.Text == "")
                errorProvider1.SetError(tbCuvant, "Va rugam introduceti cuvantul");
            else
              if (tbConjugare.Text == "")
                errorProvider1.SetError(tbConjugare, " Va rugam introduceti conjugarea");
            else
            {
                try
                {
                    valenta valVerb;
                    tipV tipVerb;
                    origineV orgVerb;

                    string cuvant = tbCuvant.Text;
                    string val = cbValenta.Text;
                    int conj = Convert.ToInt32(tbConjugare.Text);
                    string tip = cbTipVerb.Text;
                    string orig = cbProvenienta.Text;
                    string pronuntie = tbPronuntie.Text;
                    string regionalisme = tbRegionalisme.Text;
                    string origine = tbOrigine.Text;
                    string[] explicatii = new String[] { tbExplicati.Text };

                    try
                    {
                        valVerb = (valenta)Enum.Parse(typeof(valenta), val);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nu a reusit!");
                        MessageBox.Show(ex.Message);
                        valVerb = valenta.neprecizat;
                    }
                    try
                    {
                        tipVerb = (tipV)Enum.Parse(typeof(tipV), tip);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nu a reusit!");
                        MessageBox.Show(ex.Message);
                        tipVerb = tipV.neprecizat;
                    }
                    try
                    {
                        orgVerb = (origineV)Enum.Parse(typeof(origineV), orig);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nu a reusit!");
                        MessageBox.Show(ex.Message);
                        orgVerb = origineV.neprecizat;
                    }
                    verb1 v = new verb1(valVerb, conj, tipVerb, orgVerb, cuvant, pronuntie, regionalisme, origine, explicatii);
                    MessageBox.Show(v.ToString());
                    ver.Add(v);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbCuvant.Clear();
                    cbValenta.Text = "";
                    tbConjugare.Clear();
                    cbTipVerb.Text = "";
                    cbProvenienta.Text = "";
                    tbPronuntie.Clear();
                    tbRegionalisme.Clear();
                    tbOrigine.Clear();
                    tbExplicati.Clear();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (verb1 v in ver)
                tbAfisare.Text += v.ToString() + Environment.NewLine;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(tbAfisare.Text);
                sw.Close();
                tbAfisare.Clear();
            }
            this.Close();
        }

        private void salvareFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.AppendText("fisier.txt");
            foreach (verb1 a in ver)
            {
                sw.Write(a.Cuvant);
                sw.Write(",");
                sw.Write(a.Pronuntie);
                sw.Write(",");
                sw.Write(a.Regionalisme);
                sw.Write(",");
                sw.Write(a.FormaOrigine);
                sw.Write(",");
                string result = string.Join(",", a.Explicatie);
                sw.Write(result);
                sw.WriteLine();

            }
            sw.Close();
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

        private void bazeDeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            VerbDB f = new VerbDB();
            f.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Verb.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conexiune;

                cmd.CommandText = "SELECT MAX(cod) FROM verb";
                int cod = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.CommandText = "INSERT INTO verb VALUES(?,?,?,?,?,?,?,?,?,?)";
                cmd.Parameters.Add("@Cod", OleDbType.Integer).Value = cod + 1;
                cmd.Parameters.AddWithValue("@Cuvant", this.tbCuvant.Text);
                cmd.Parameters.AddWithValue("@Valenta", this.cbValenta.Text);
                cmd.Parameters.AddWithValue("@Conjugare", this.tbConjugare.Text);
                cmd.Parameters.AddWithValue("@Tip", this.cbTipVerb .Text);
                cmd.Parameters.AddWithValue("@Provenienta", this.cbProvenienta.Text);
                cmd.Parameters.AddWithValue("@Pronuntie", this.tbPronuntie.Text);
                cmd.Parameters.AddWithValue("@Regionalisme", this.tbRegionalisme.Text);
                cmd.Parameters.AddWithValue("@Origine", this.tbOrigine.Text);
                cmd.Parameters.AddWithValue("@Explicatii", this.tbExplicati.Text);
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
    }
}

