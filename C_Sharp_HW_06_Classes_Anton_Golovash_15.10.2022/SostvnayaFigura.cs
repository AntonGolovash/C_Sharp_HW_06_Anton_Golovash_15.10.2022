using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_HW_06_Classes_Anton_Golovash_15._10._2022
{
    public class SostavnayaFigura
    {
        public static double PloshadSostavnoyFigury(List<IProstoyNUgolnik> figuras)
        {
            double ploshad = 0;
            foreach (var item in figuras)
            {
                ploshad += item.Ploshad();
            }
            return ploshad;
        }

    }
}
