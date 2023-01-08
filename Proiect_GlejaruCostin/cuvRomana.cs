using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect_GlejaruCostin
{
    [Serializable]
    class cuvRomana:Cuvant,ICloneable
    {
        private string cuvant;
        private string pronuntie;
        private string regionalisme;
        private string formaOrigine;

        public cuvRomana():base()
        {
            cuvant= "necunoscut";
            pronuntie = "necunoscut";
            regionalisme = "necunoscut";
            formaOrigine = "necunoscut";
        }
        public cuvRomana(string c,string p,string r,string o,string[] e):base(e)
        {
            cuvant = c;
            pronuntie = p;
            regionalisme = r;
            formaOrigine = o;
        }
        public cuvRomana(cuvRomana cr)
        {
            cuvant = cr.cuvant;
            pronuntie = cr.pronuntie;
            regionalisme = cr.regionalisme;
            formaOrigine = cr.formaOrigine;

        }

        

        public string Cuvant
        {
            get { return cuvant; }
            set { if (value != null) cuvant = value; }
        }
       
       
        public string Pronuntie
        {
            get { return pronuntie;  }
            set { if (value != null) pronuntie = value; }
        }
        public string Regionalisme
        {
            get { return regionalisme; }
            set { if (value != null) regionalisme = value; }
        }
        public string FormaOrigine
        {
            get { return formaOrigine; }
            set { if (value != null) formaOrigine = value; }
        }


        
        public override string ToString()
        {
            return "Cuvantul " + cuvant +  " are urmatoarea pronuntie "
                + pronuntie + ". Acesta are urmatorul/urmatoarele regionalism/regionalism: " + regionalisme  +Environment.NewLine +  ". De asemenea, acesta are forma in limba de origine " + formaOrigine +". " + base.ToString() + "Cuvantul";
        }
        public char LimbaOrigine
        {
            get;set;
        }
       
        public object Clone()
        {
            cuvRomana clona = (cuvRomana)this.MemberwiseClone();
            return clona;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            return this.cuvant == obj.ToString();
        }
        public override int GetHashCode()
        {
            return this.cuvant.GetHashCode();
        }
        private static string CompareStrings(string str1, string str2)
        {
            int cmp = str1.CompareTo(str2);
            if (cmp == 0)
                return "E acelasi string";
            else
                if (cmp < 0)
                return "Primul string e precedat de al doilea in ordinea sortarii";
            else
                return "Primul string este dupa al doilea string";
        }

        //public int CompareTo(object obj)
        //{
        //    cuvRomana c = (cuvRomana)obj;
        //    return 0;

        //}
        //public static cuvRomana operator ++(cuvRomana c)
        //{
        //    return c + 1;
        //}
        public static bool IsLessThan(String a, String b)
        {
            return a.CompareTo(b)<0;
        }
        public static bool IsGreaterThan(String a, String b)
        {
            return a.CompareTo(b)>0;
        }

        //public int CompareTo(object obj)
        //{
        //    TipRomana tip1 = TipRomana.substantiv;
        //    TipRomana tip2 = TipRomana.adjectiv;
        //    return tip1.Equals(tip2) ? 0 : 1;
        //}
        // versiune 1
        //public int CompareTo(object obj)
        //{
        //    if ((TipRomana.substantiv | TipRomana.adjectiv) > 0)
        //        return -1;
        //    else
        //    {
        //        return (TipRomana.substantiv | TipRomana.adjectiv) < 0 ? -1 : 0;
        //    }
        //}
    }
    
}
