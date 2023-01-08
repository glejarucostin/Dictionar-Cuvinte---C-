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
    public partial class Substantiv : Form
    {
        List<substantiv1> subst = new List<substantiv1>();
        public Substantiv()
        {
            InitializeComponent();
        }
        public delegate void delPassData(TextBox text);
        private void intoarcereLaRomana1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RomanaOF f = new RomanaOF();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbCuvant.Text == "")
                errorProvider1.SetError(tbCuvant, "Va rugam introduceti cuvantul");
            else
            {
                try
                {
                    gen ge;
                    clasificare c;
                    numar n;
                    declinare d;
                    proveninenta p;
                    string cuvant = tbCuvant.Text;
                    string genCuvant = cbGen.Text;
                    string clasificareSubstantiv = cbClasificare.Text;
                    string numarSubstantiv = cbNumar.Text;
                    string declinareSubstantiv = cbDeclinare.Text;
                    string proveninentaSubstantiv = cbProvenienta.Text;
                    string pronuntie = tbPronuntie.Text;
                    string regionalisme = tbRegionalisme.Text;
                    string origine = tbOrigine.Text;
                    string[] explicatii = new String[] { tbExplicati.Text };

                    try
                    {
                        ge = (gen)Enum.Parse(typeof(gen), genCuvant);
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Nu a reusit");
                        Console.WriteLine(ex.Message);
                        ge = gen.neprecizat;

                    }
                    try
                    {
                        c = (clasificare)Enum.Parse(typeof(clasificare), clasificareSubstantiv);
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Nu a reusit");
                        Console.WriteLine(ex.Message);
                        c = clasificare.neprecizat;
                    }
                    try
                    {
                        n = (numar)Enum.Parse(typeof(numar), numarSubstantiv);
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Nu a reusit");
                        Console.WriteLine(ex.Message);
                        n = numar.neprecizat;
                    }
                    try
                    {
                        d = (declinare)Enum.Parse(typeof(declinare), declinareSubstantiv);
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Nu a reusit");
                        Console.WriteLine(ex.Message);
                        d = declinare.neprecizat;
                    }
                    try
                    {
                        p = (proveninenta)Enum.Parse(typeof(proveninenta), proveninentaSubstantiv);
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Nu a reusit");
                        Console.WriteLine(ex.Message);
                        p = proveninenta.neprecizat;
                    }
                    substantiv1 s = new substantiv1(ge, c, n, d, p, cuvant, pronuntie, regionalisme, origine, explicatii);
                    MessageBox.Show(s.ToString());
                    subst.Add(s);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbCuvant.Clear();
                    cbGen.Text = "";
                    cbClasificare.Text = "";
                    cbNumar.Text = "";
                    cbDeclinare.Text = "";
                    cbProvenienta.Text = "";
                    tbPronuntie.Clear();
                    tbRegionalisme.Clear();
                    tbOrigine.Clear();
                    tbExplicati.Clear();

                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
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


        private void button3_Click(object sender, EventArgs e)
        {
            foreach (substantiv1 c in subst)
                tbAfisare.Text += c.ToString() + Environment.NewLine;
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

        private void salvareFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.AppendText("fisier.txt");
            foreach (substantiv1 a in subst)
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

        private void bazaDeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubstantivBD f = new SubstantivBD();
            f.Show();
        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Substantiv1.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conexiune;

                cmd.CommandText = "SELECT MAX(cod) FROM substantiv";
                int cod = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.CommandText = "INSERT INTO substantiv values(?,?,?,?,?,?,?,?,?,?,?)";
                cmd.Parameters.Add("@Cod", OleDbType.Integer).Value = cod + 1;
                cmd.Parameters.AddWithValue("@Cuvant", this.tbCuvant.Text);
                cmd.Parameters.AddWithValue("@Gen", this.cbGen.Text);
                cmd.Parameters.AddWithValue("@Clasificare", this.cbClasificare.Text);
                cmd.Parameters.AddWithValue("@Numar", this.cbNumar.Text);
                cmd.Parameters.AddWithValue("@Declinare", this.cbDeclinare.Text);
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


