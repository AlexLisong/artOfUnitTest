using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProj
{
    public class HYBargainRequire
    {
        public double Money { get; set; }

        public double DisCountMoney{get;set;}

        public BargainRule BargainRule{get;set;}


    }

    public class BargainRule
    {
        public double BargainMaxPricePercent{get;set;}

        public double BargainLimitPricePercent{get;set;}


    }
}
