using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_GlejaruCostin
{
    [Serializable]
    enum gen{
        masculin,
        feminin,
        neutru,
        neprecizat

    }
    enum clasificare
    {
        comun,
        propriu,
        neprecizat

    }
    enum numar
    {
        singural,
        plural,
        neprecizat

    }
    enum declinare
    {
        subiect,
        atribut,
        complement,
        nume_predicativ,
        neprecizat
    }
    enum proveninenta
    {
        adjectiv,
        numeral,
        verb,
        adverb,
        compunere,
        conversiune,
        neprecizat
    }
    class substantiv1:cuvRomana,ICloneable,IComparable
    {
        public gen genSubstantiv;
        public clasificare clasificareSubstantiv;
        public numar numarSubstantivului;
        public declinare declinareaSubstantivului;
        public proveninenta proveninentaSubstantivului;

        public substantiv1():base()
        {
            genSubstantiv = default;
            clasificareSubstantiv = default;
            numarSubstantivului = default;
            declinareaSubstantivului = default;
            proveninentaSubstantivului = default;
        }
        public substantiv1(gen g,clasificare c,numar n,declinare d,proveninenta p, string cu, string pr, string r, string o, string[] e) : base(cu, pr, r, o, e)
        {
            genSubstantiv= g;
            clasificareSubstantiv = c;
            numarSubstantivului = n;
            declinareaSubstantivului = d;
            proveninentaSubstantivului = p;


        }
        public substantiv1(substantiv1 s)
        {
            genSubstantiv = s.genSubstantiv;
            clasificareSubstantiv = s.clasificareSubstantiv;
            numarSubstantivului = s.numarSubstantivului;
            declinareaSubstantivului = s.declinareaSubstantivului;
            proveninentaSubstantivului = s.proveninentaSubstantivului;
        }
        public void setGen(gen input)
        {
            genSubstantiv = input;
        }
        public void setClasificare(clasificare input)
        {
            clasificareSubstantiv = input;
        }
        public void setNumar(numar input)
        {
            numarSubstantivului = input;
        }
        public void setDeclinare(declinare input)
        {
            declinareaSubstantivului = input;
        }
        public void setProvenienta(proveninenta input)
        {
            proveninentaSubstantivului = input;
        }
        public override string ToString()
        {
            return base.ToString() + " care are genul " + genSubstantiv + " este un " + clasificareSubstantiv +"." + " Este la numarul " + numarSubstantivului +"." 
                + "Reprezinta declinarea " + declinareaSubstantivului + " si provine din " + proveninentaSubstantivului;
        }

        public object Clone1()
        {
            substantiv1 clona = (substantiv1)this.MemberwiseClone();
            return clona;
        }

        public int CompareTo(object obj)
        {
            clasificare tip1 = clasificare.comun;
            clasificare tip2 = clasificare.propriu;
            return tip1.Equals(tip2) ? 0 : 1;
        }
    }
}
