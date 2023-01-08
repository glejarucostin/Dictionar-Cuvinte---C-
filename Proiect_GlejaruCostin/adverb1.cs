using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_GlejaruCostin
{
    [Serializable]
    enum tipAdv
    {
        simplu,
        compus,
        neprecizat
    }
    enum categorieAdv
    {
        loc,
        timp,
        mod,
        neprecizat
    }
    enum gradComparatie
    {
        pozitiv,
        comparativ,
        superlativ,
        neprecizat
    }
    enum contextAdv
    {
        demonstativ,
        nehotarat,
        negativ,
        interogativ,
        neprecizat
    }
    enum functieAdv
    {
        atribut,
        nume_predicativ,
        complement,
        neprecizat
    }
    class adverb1:cuvRomana,ICloneable,IComparable
    {
        public tipAdv tipAdverb;
        public categorieAdv categorieAdverb;
        public gradComparatie gradComparatieAdverb;
        public contextAdv contextAdverb;
        public functieAdv functiiAdverb;

        public adverb1():base()
        {
            tipAdverb = default;
            categorieAdverb = default;
            gradComparatieAdverb = default;
            contextAdverb = default;
            functiiAdverb = default;
        }
        public adverb1(tipAdv t,categorieAdv c,gradComparatie g,contextAdv ca,functieAdv f, string cu, string p, string r, string o, string[] e) : base(cu, p, r, o, e)
        {
            tipAdverb = t;
            categorieAdverb = c;
            gradComparatieAdverb = g;
            contextAdverb = ca;
            functiiAdverb = f;
        }
        public adverb1(adverb1 a)
        {
            tipAdverb = a.tipAdverb;
            categorieAdverb = a.categorieAdverb;
            gradComparatieAdverb = a.gradComparatieAdverb;
            contextAdverb = a.contextAdverb;
            functiiAdverb = a.functiiAdverb;
        }
        public void setTipAdverb(tipAdv input)
        {
            tipAdverb = input;
        }
        public void setCategorie(categorieAdv input)
        {
            categorieAdverb = input;
        }
        public void setGrad(gradComparatie input)
        {
            gradComparatieAdverb = input;
        }
        public void setContext(contextAdv input)
        {
            contextAdverb = input;
        }
        public void setFunctie(functieAdv input)
        {
            functiiAdverb = input;
        }
        public override string ToString()
        {
            return base.ToString() +  " este un adverb " + tipAdverb + "." + "Reprezinta un adverb de " + categorieAdverb + " , Acesta are gradul de comparatie " + gradComparatieAdverb + "."
                + " In functie de context, acesta poate fi un adverb " + contextAdverb + " iar in propozitie indeplineste rolul de " + functiiAdverb ;
        }

        public object Clone1()
        {
            adverb1 clona = (adverb1)this.MemberwiseClone();
            return clona;
        }

        public int CompareTo(object obj)
        {
            tipAdv tip1 = tipAdv.simplu;
            tipAdv tip2 = tipAdv.compus;
            return tip1.Equals(tip2) ? 0 : 1;
        }
    }
}
