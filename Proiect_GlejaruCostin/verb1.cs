using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_GlejaruCostin
{
    [Serializable]
    enum valenta
    {
        impersonal,
        tranzitiv,
        intranzitiv,
        bitranzitiv,
        neprecizat

    }
    enum tipV
    {
        personal,
        impersonal,
        neprecizat

    }
    enum origineV
    {
        substantiv,
        adverb,
        adjectiv,
        numeral,
        interjectie,
        pronume,
        neprecizat

    }
    class verb1:cuvRomana,ICloneable,IComparable
    {
        public valenta valentaVerbului;
        int conjugare;
        public tipV tipulVerbului;
        public origineV origineaVerbului;

        public verb1():base()
        {
            valentaVerbului = default;
            conjugare = 0;
            tipulVerbului = default;
            origineaVerbului = default;
        }

        public verb1(valenta v,int c,tipV t,origineV o, string cu, string pr, string r, string or, string[] e) : base(cu, pr, r, or, e)
        {
            valentaVerbului = v;
            conjugare = c;
            tipulVerbului = t;
            origineaVerbului = o;
        }
        public verb1(verb1 v)
        {
            valentaVerbului = v.valentaVerbului;
            conjugare = v.conjugare;
            tipulVerbului = v.tipulVerbului;
            origineaVerbului = v.origineaVerbului;
        }
        public int Conjugare
        {
            get; set;
        }
        public void setTipVerb(tipV input)
        {
            tipulVerbului = input;
        }
        public void setValenta(valenta input)
        {
            valentaVerbului = input;
        }
        public void setOrigineVerb(origineV input)
        {
            origineaVerbului = input;
        }
        public override string ToString()
        {
            return base.ToString() + " este un verb " + valentaVerbului + " aflandu-se la conjugarea " + conjugare + "." + " De asemenea acesta este un verb " + tipulVerbului 
                + " fiind la origine un " + origineaVerbului;
        }

        public object Clone1()
        {
            verb1 clona = (verb1)this.MemberwiseClone();
            return clona;
        }

        public int CompareTo(object obj)
        {
            tipV tip1 = tipV.personal;
            tipV tip2 = tipV.impersonal;
            return tip1.Equals(tip2) ? 0:1;
        }

        public static verb1 operator -(verb1 p, int conj)
        {
            p.conjugare -= conj;
            return p;
        }
    }
}
