using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect_GlejaruCostin
{
    [Serializable]
    public enum TipEngleza
    {
        noun,
        adjective,
        pronoun,
        verb,
        unspecified
    }
    class cuvEngleza:Cuvant,ICloneable,IComparable

    { 
        private string cuvEngl;
        public TipEngleza tipulCuvantului;
        private string pronuntie;
        private string formaPlural;
        private string formaUK;
        private string formaUS;
        private string origineE;

        public string CuvEngl
        {
            get { return cuvEngl; }
            set { if (value != null) cuvEngl = value; }
        }
        public string Pronuntie
        {
            get { return pronuntie; }
            set { if (value != null) pronuntie = value; }
        }
        public string FormaPlural
        {
            get { return formaPlural; }
            set { if (value != null) formaPlural = value; }
        }
        public string FormaUK
        {
            get { return formaUK; }
            set { if (value != null) formaUK = value; }
        }
        public string FormaUS
        {
            get { return formaUS; }
            set { if (value != null) formaUS = value; }
        }
        
        public TipEngleza TipulCurent
        {
            get { return tipulCuvantului; }
            set { tipulCuvantului = value; }
        }
        public string OrigineE
        {
            get { return origineE; }
            set { if (value != null) origineE = value; }
        }

        public cuvEngleza():base()
        {
            cuvEngl = "necunoscut";
            tipulCuvantului = default;
            pronuntie = "necunoscut";
            FormaPlural = "necunoscut";
            formaUS = "necunoscut";
            formaUK = "necunoscut";
            origineE = "necunoscut";
        }
        public cuvEngleza(string c,TipEngleza t,string p,string f ,string fUS,string fUK,string o,string[] e):base(e)
        {
            cuvEngl = c;
            tipulCuvantului = t;
            pronuntie = p;
            formaPlural = f;
            formaUS = fUS;
            formaUK = fUK;
            origineE = o;
        }
        public override string ToString()
        {
            return "Cuvantul " + cuvEngl + " care este un " + tipulCuvantului + " are urmatoarea pronuntie " + pronuntie + " avand o forma pentru Engleza Americana " + formaUS + " si o forma pentru Engleza Britanica " + formaUK  + ". De asemenea, la plural are forma " 
                 + formaPlural + " ,3urmatoarea origine " + origineE + base.ToString();
        }
        public cuvEngleza(cuvEngleza ce)
        {
            cuvEngl = ce.cuvEngl;
            tipulCuvantului = ce.tipulCuvantului;
            pronuntie = ce.pronuntie;
            formaPlural = ce.formaPlural;
            formaUS = ce.formaUS;
            formaUK = ce.formaUK;
            origineE = ce.origineE;
        }
        public object Clone()
        {
            cuvEngleza clona = (cuvEngleza)this.MemberwiseClone();
            return clona;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            return this.cuvEngl == obj.ToString();
        }
        public override int GetHashCode()
        {
            return this.cuvEngl.GetHashCode();
        }
        private static string CompareStrings(string str1,string str2)
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

        public int CompareTo(object obj)
        {
            //TipEngleza tip = (TipEngleza)Enum.Parse(typeof(TipEngleza), "noun");
            //cuvEngleza c = (cuvEngleza)obj;
            //if (c.tip.CompareTo(obj))
            //    return 1;
            TipEngleza tip1 = TipEngleza.noun;
            TipEngleza tip2 = TipEngleza.adjective;
            //if ((TipEngleza.adjective | TipEngleza.noun) > 0)
            //    return 1;
            //else
            //    if ((TipEngleza.adjective | TipEngleza.noun) < 0)
            //    return -1;
            //else
            //    return 0;
                return tip1.Equals(tip2) ? 0 : 1 ;


        }
    }
}
