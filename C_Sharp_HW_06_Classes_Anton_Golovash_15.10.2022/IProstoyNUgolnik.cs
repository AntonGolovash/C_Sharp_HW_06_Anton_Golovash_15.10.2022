using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_HW_06_Classes_Anton_Golovash_15._10._2022
{
    public interface IProstoyNUgolnik
    {
        double Vysota();
        double Osnovanie();
        double UgolMeghduOsnovaniemISmeghnoyStoronoy();
        int KolichestvoStoron();
        double DlinyStoron();
        double Ploshad();
        double Perimetr();
    }
}
