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
    public partial class Adverb : Form
    {
        List<adverb1> adv = new List<adverb1>();
        public Adverb()
        {
            InitializeComponent();
        }

        private void intoarcereLaRomana1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            //Romana1 f = new Romana1();
            //f.Show();
        }

        private void intoarcereLaMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Main f = new Main();
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

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (tbCuvant.Text == "")
                errorProvider1.SetError(tbCuvant, "Va rugam introduceti cuvantul!");
            else
            {
                try
                {
                    tipAdv tip;
                    categorieAdv categ;
                    gradComparatie grad;
                    contextAdv context;
                    functieAdv functie;
                    string cuvant = tbCuvant.Text;
                    string tipAdverb = cbTipAdverb.Text;
                    string categorieAdverb = cbCategorieAdverb.Text;
                    string gradAdverb = cbGradComp.Text;
                    string contextAdverb = cbContext.Text;
                    string functieAdverb = cbFunctie.Text;
                    string pronuntie = tbPronuntie.Text;
                    string regionalisme = tbRegionalisme.Text;
                    string origine = tbOrigine.Text;
                    string[] explicatii = new String[] { tbExplicati.Text };

                    try
                    {
                        tip = (tipAdv)Enum.Parse(typeof(tipAdv), tipAdverb);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nu a reusit!");
                        MessageBox.Show(ex.Message);
                        tip = tipAdv.neprecizat;
                    }
                    try
                    {
                        categ = (categorieAdv)Enum.Parse(typeof(categorieAdv), categorieAdverb);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nu a reusit!");
                        MessageBox.Show(ex.Message);
                        categ = categorieAdv.neprecizat;
                    }
                    try
                    {
                        grad = (gradComparatie)Enum.Parse(typeof(gradComparatie), gradAdverb);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nu a reusit!");
                        MessageBox.Show(ex.Message);
                        grad = gradComparatie.neprecizat;
                    }
                    try
                    {
                        context = (contextAdv)Enum.Parse(typeof(contextAdv), contextAdverb);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nu a reusit!");
                        MessageBox.Show(ex.Message);
                        context = contextAdv.neprecizat;
                    }
                    try
                    {
                        functie = (functieAdv)Enum.Parse(typeof(functieAdv), functieAdverb);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nu a reusit!");
                        MessageBox.Show(ex.Message);
                        functie = functieAdv.neprecizat;
                    }
                    adverb1 a = new adverb1(tip, categ, grad, context, functie, cuvant, pronuntie, regionalisme, origine, explicatii);
                    MessageBox.Show(a.ToString());
                    adv.Add(a);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbCuvant.Clear();
                    cbTipAdverb.Text = "";
                    cbCategorieAdverb.Text = "";
                    cbGradComp.Text = "";
                    cbContext.Text = "";
                    cbFunctie.Text = "";
                    tbPronuntie.Clear();
                    tbRegionalisme.Clear();
                    tbOrigine.Clear();
                    tbExplicati.Clear();
                }
            }
        }

        private void tbnAfisare_Click(object sender, EventArgs e)
        {
            foreach (adverb1 a in adv)
                tbAfisare.Text += a.ToString() + Environment.NewLine;

        }



        private void salvareFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.AppendText("fisier.txt");
            foreach (adverb1 a in adv)
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
            this.Close();
            AdverbDB f = new AdverbDB();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Adverb.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conexiune;

                cmd.CommandText = "SELECT MAX(cod) FROM adverb";
                int cod = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.CommandText = "INSERT INTO adverb VALUES(?,?,?,?,?,?,?,?,?,?,?)";
                cmd.Parameters.Add("@Cod", OleDbType.Integer).Value = cod + 1;
                cmd.Parameters.AddWithValue("@Cuvant", this.tbCuvant.Text);
                cmd.Parameters.AddWithValue("@Tip", this.cbTipAdverb.Text);
                cmd.Parameters.AddWithValue("@Categorie", this.cbCategorieAdverb.Text);
                cmd.Parameters.AddWithValue("@Grad_comparatie", this.cbGradComp.Text);
                cmd.Parameters.AddWithValue("@Context", this.cbContext.Text);
                cmd.Parameters.AddWithValue("@Functie", this.cbFunctie.Text);
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
