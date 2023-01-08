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
    public partial class Adjectiv : Form
    {
        List<adjectiv1> adj = new List<adjectiv1>();
        public Adjectiv()
        {
            InitializeComponent();
        }

        
        private void intoarcereMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main f = new Main();
            f.Show();

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (tbCuvant.Text == "")
                errorProvider1.SetError(tbCuvant, "Va rugam introduceti cuvantul!");
            else
            {
                try
                {
                    clasificareAtr cA;
                    mijloaceExprimare mE;
                    valoareStilistica vS;
                    string cuvant = tbCuvant.Text;
                    string clas = cbClasificare.Text;
                    string mij = cbMijloc.Text;
                    string val = cbValoarea.Text;
                    string pronuntie = tbPronuntie.Text;
                    string regionalisme = tbRegionalisme.Text;
                    string origine = tbOrigine.Text;
                    string[] explicatii = new String[] { tbExplicati.Text };
                    try
                    {
                        cA = (clasificareAtr)Enum.Parse(typeof(clasificareAtr), clas);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Nu a reusit");
                        Console.WriteLine(ex.Message);
                        cA = clasificareAtr.neprecizat;
                    }
                    try
                    {
                        mE = (mijloaceExprimare)Enum.Parse(typeof(mijloaceExprimare), mij);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Nu a reusit");
                        Console.WriteLine(ex.Message);
                        mE = mijloaceExprimare.neprecizat;
                    }
                    try
                    {
                        vS = (valoareStilistica)Enum.Parse(typeof(valoareStilistica), val);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Nu a reusit");
                        Console.WriteLine(ex.Message);
                        vS = valoareStilistica.neprecizat;
                    }

                    adjectiv1 a = new adjectiv1(cA, mE, vS, cuvant, pronuntie, regionalisme, origine, explicatii);
                    MessageBox.Show(a.ToString());
                    adj.Add(a);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbCuvant.Clear();
                    cbClasificare.Text = "";
                    cbMijloc.Text = "";
                    cbValoarea.Text = "";
                    tbPronuntie.Clear();
                    tbRegionalisme.Clear();
                    tbOrigine.Clear();
                    tbExplicati.Clear();
                }
            }
        }

        private void tbAfisare_TextChanged(object sender, EventArgs e)
        {
            tbAfisare.ScrollBars = ScrollBars.Both;
            tbAfisare.WordWrap = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (adjectiv1 a in adj)
                tbAfisare.Text += a.ToString() + Environment.NewLine;
        }


        


        private void serializareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, tbAfisare.Text);
            fs.Close();
            tbAfisare.Clear();

        }

        private void deserializareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            tbAfisare.Text = (string)bf.Deserialize(fs);
            fs.Close();

        }

        private void scriereFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.AppendText("fisier.txt");
            foreach (adjectiv1 a in adj)
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

        private void bazaDeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            AdjectivBD f = new AdjectivBD();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Adjectiv.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conexiune;

                cmd.CommandText = "SELECT MAX(cod) FROM adjectiv";
                int cod = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.CommandText = "INSERT INTO adjectiv VALUES(?,?,?,?,?,?,?,?,?)";
                cmd.Parameters.Add("@Cod", OleDbType.Integer).Value = cod + 1;
                cmd.Parameters.AddWithValue("@Cuvant", this.tbCuvant.Text);
                cmd.Parameters.AddWithValue("@Clasificare", this.cbClasificare.Text);
                cmd.Parameters.AddWithValue("@Mijloc_exprimare", this.cbMijloc.Text);
                cmd.Parameters.AddWithValue("@Val_stilistica", this.cbValoarea.Text);
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
