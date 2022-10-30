using C_Sharp_HW_06_Classes_Anton_Golovash_15._10._2022;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_Sharp_HW_06_Anton_Golovash_15._10._2022
{
    public class Program
    {
        static void Main(string[] args)
        {
            IProstoyNUgolnik ellips = new Ellips();
            ellips.Ploshad();

            IProstoyNUgolnik krug = new Krug();
            IProstoyNUgolnik kvadrat = new Kvadrat();
            IProstoyNUgolnik parallelogramm = new Parallelogramm();
            IProstoyNUgolnik priamougolnik = new Priamougolnik();
            IProstoyNUgolnik romb = new Romb();
            IProstoyNUgolnik trapecia = new Trapecia();
            IProstoyNUgolnik treugolnik = new Treugolnik ();
        }
    }
}
