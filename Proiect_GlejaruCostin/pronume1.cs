using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_GlejaruCostin
{
    [Serializable]
    enum tipP
    {
        personal,
        politete,
        reflexiv,
        intarire,
        posesiv,
        demonstrativ,
        interogativ,
        relativ,
        nehotarat,
        negativ,
        neprecizat
    }
    class pronume1:cuvRomana,IComparable,ICloneable
    {
        public tipP tipPronume;
        public int numarPersoana;
        char tipPersoana;

        public pronume1():base()
        {
            tipPronume = default;
            numarPersoana = 0;
            tipPersoana = 'M';
        }
        public pronume1(tipP t,int nr,char ti, string cu, string p, string r, string o, string[] e) : base(cu, p, r, o, e)
        {
            tipPronume = t;
            numarPersoana = nr;
            tipPersoana = ti;
        }
        public pronume1(pronume1 p)
        {
            tipPronume = p.tipPronume;
            numarPersoana = p.numarPersoana;
            tipPersoana = p.tipPersoana;
        }

        public void setTipPronume(tipP input)
        {
            tipPronume = input;
        }
        int NumarPersoana { get; set; }
        char TipPersoana { get; set; }

        public override string ToString()
        {
            return base.ToString() + " este un pronume " + tipPronume +" care este la persoana " +numarPersoana + " si este de tipul (singural/plural) " + tipPersoana; 
        }
        public int CompareTo(object obj)
        {
            pronume1 p = (pronume1)obj;
            if (this.numarPersoana < p.numarPersoana)
                return -1;
            else
                if (this.numarPersoana > p.numarPersoana)
                return 1;
            return 0;
        }

        public object Clone1()
        {
            pronume1 clona = (pronume1)this.MemberwiseClone();
            return clona;
        }

        public static pronume1 operator +(pronume1 p,int pers)
        {
            p.numarPersoana += pers;
            return p;
        }
        public static pronume1 operator+(int pers,pronume1 p)
        {
            return p + pers;
        }
        public static pronume1 operator -(int pers, pronume1 p)
        {
            return p + pers;
        }
        public static pronume1 operator-(pronume1 p,int pers)
        {
            p.numarPersoana -= pers;
            return p;
        }
        

    }
}
