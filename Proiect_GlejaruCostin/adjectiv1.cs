using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_GlejaruCostin
{ 
    [Serializable]
    enum clasificareAtr
    {
        substantival,
        adjectival,
        pronominal,
        numeral,
        verbal,
        adverbial,
        interjectional,
        neprecizat
    }
    enum mijloaceExprimare
    {
        substantiv,
        adjectiv,
        pronume,
        numeral,        
        verb,
        adverb,
        interjectie,
        neprecizat
    }
    enum valoareStilistica
    {
        epitet,
        comparatie,
        metafora,
        neprecizat
    }
    class adjectiv1:cuvRomana,ICloneable//,IComparable
    {
        public clasificareAtr clasif;
        public mijloaceExprimare mijloace;
        public valoareStilistica valoare;


        public adjectiv1():base()
        {
            clasif = default;
            mijloace = default;
            valoare = default;
        }
        public adjectiv1(clasificareAtr c,mijloaceExprimare m,valoareStilistica v, string cu,  string p, string r, string o,string[]e) :base(cu,p,r,o,e)

        {
            clasif = c;
            mijloace = m;
            valoare = v;
        }
        public adjectiv1(adjectiv1 a)
        {
            clasif = a.clasif;
            mijloace = a.mijloace;
            valoare = a.valoare;
        }
        public void setClasificareAtribut(clasificareAtr input)
        {
            clasif = input;
        }
        public void setMijloaceAtribut(mijloaceExprimare input)
        {
            mijloace = input;
        }
        public void setValoareStilistica(valoareStilistica input)
        {
            valoare = input;
        }
        public override string ToString()
        {
            return base.ToString() + " este un atribut, avand tipul " + clasif + " exprimat pe baza unui " + mijloace + " avand valoarea stilistica de " + valoare + "." ;
        }

        public object Clone1()
        {
            adjectiv1 clona = (adjectiv1)this.MemberwiseClone();
            return clona;
        }

        public int CompareTo1(object obj)
        {
            valoareStilistica tip1 = valoareStilistica.metafora;
            valoareStilistica tip2 = valoareStilistica.epitet;
            return tip1.Equals(tip2) ? 0 : 1; 
        }

        //public int CompareTo(object obj)
        //{
        //    clasificareAtr atr;
        //    Enum.TryParse("Valoare statistica", out valoareStilistica valoare);
        //}
    }
}
