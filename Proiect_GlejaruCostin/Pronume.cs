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
    public partial class Pronume : Form
    {
        List<pronume1> pron = new List<pronume1>();
        public Pronume()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbCuvant.Text == "")
                errorProvider1.SetError(tbCuvant, "Va rugam introduceti cuvantul");
            else
            if (tbNumar.Text == "")
                errorProvider1.SetError(tbNumar, "Va rugam introduceti numarul persoanei");
            else
            {
                try
                {
                    tipP tip;
                    string cuvant = tbCuvant.Text;
                    string tipulPronumelui = cbTipPronume.Text;
                    int numar = Convert.ToInt32(tbNumar.Text);
                    char tipPersoana = Convert.ToChar(tbTipPers.Text);
                    string pronuntie = tbPronuntie.Text;
                    string regionalisme = tbRegionalisme.Text;
                    string origine = tbOrigine.Text;
                    string[] explicatii = new String[] { tbExplicati.Text };

                    try
                    {
                        tip = (tipP)Enum.Parse(typeof(tipP), tipulPronumelui);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Nu a reusit");
                        Console.WriteLine(ex.Message);
                        tip = tipP.neprecizat;
                    }
                    pronume1 p = new pronume1(tip, numar, tipPersoana, cuvant, pronuntie, regionalisme, origine, explicatii);
                    MessageBox.Show(p.ToString());
                    pron.Add(p);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbCuvant.Clear();
                    cbTipPronume.Text = "";
                    tbNumar.Clear();
                    tbTipPers.Clear();
                    tbPronuntie.Clear();
                    tbRegionalisme.Clear();
                    tbOrigine.Clear();
                    tbExplicati.Clear();

                }
            }
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            foreach (pronume1 p in pron)
                tbAfisare.Text += p.ToString() + Environment.NewLine;
        }

        private void btnTrimitere_Click(object sender, EventArgs e)
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
            foreach (pronume1 a in pron)
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

        private void intoarcereMeniuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            RomanaOF f = new RomanaOF();
            f.Show();
        }

        private void bazeDeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            PronumeDB f = new PronumeDB();
            f.Show();
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Pronume.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conexiune;

                cmd.CommandText = "SELECT MAX(cod) FROM pronume";
                int cod = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.CommandText = "INSERT INTO pronume VALUES(?,?,?,?,?,?,?,?,?)";
                cmd.Parameters.Add("@Cod", OleDbType.Integer).Value = cod + 1;
                cmd.Parameters.AddWithValue("@Cuvant", this.tbCuvant.Text);
                cmd.Parameters.AddWithValue("@Tipul", this.cbTipPronume.Text);
                cmd.Parameters.AddWithValue("@Numarul", this.tbNumar.Text);
                cmd.Parameters.AddWithValue("@Tip_pers", this.tbTipPers.Text);
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
