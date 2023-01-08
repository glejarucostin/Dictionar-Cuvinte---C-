using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proiect_GlejaruCostin
{
    [Serializable]
    class Cuvant
    {
        private string[] explicatie;

        public Cuvant()
        {
            explicatie = null;
        }
        public Cuvant(string[] e)
        {
            explicatie = new string[e.Length];
            for (int i=0;i<e.Length;i++)
            {
                explicatie[i] = e[i];
            }
        }
        
        public Cuvant(Cuvant e)
        {
            explicatie = new string[e.explicatie.Length];
            for(int i=0;i<e.explicatie.Length;i++)
            {
                explicatie[i] = e.explicatie[i];
            }
        }
        public override string ToString()
        {
            string rezultat = "Cuvantul are urmatoarele explicatii:" + Environment.NewLine;
            for(int i=0;i<explicatie.Length;i++)
            {
                rezultat += explicatie[i] + Environment.NewLine;
            }

            return rezultat;
        }
        //public String Explicatie
        //{
        //    get { return explicatie.ToArray; }
        //    set { if (value != null) 
        //            explicatie = new String[value.Length];
        //    for(int i = 0; i < value.Length; i++)
        //        {
        //            explicatie[i] = value[i].ToString();
        //        }
        //    }
        //}
        public String[] Explicatie
        {
            get { return explicatie;  }
            set { if (value != null) explicatie = value; }
        }
    }
}
