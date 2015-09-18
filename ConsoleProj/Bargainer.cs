using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProj
{
    class Bargainer
    {
        public bool Bargain(HYBargainRequire bargainRequire, out double bargainMoney)
        {
            //可以被砍的总金额
            double availableTotalDiscount = bargainRequire.Money * bargainRequire.BargainRule.BargainMaxPricePercent;
            //可以被砍的剩余金额
            double availableRemainDiscount = availableTotalDiscount - bargainRequire.DisCountMoney;

            if (availableRemainDiscount <= 1)
            {
                bargainMoney = Math.Round(availableRemainDiscount, 2);
            }
            else
            {
                //单次砍价金额上限
                double bargainCeiling = availableRemainDiscount * bargainRequire.BargainRule.BargainLimitPricePercent;

                bargainMoney = 0;
                while (bargainMoney == 0)
                {

                    double randomPercent = new Random().NextDouble();


                    bargainMoney = Math.Round(bargainCeiling * randomPercent, 2);

                    if (bargainMoney > bargainCeiling)
                    {
                        bargainMoney -=0.01;
                    }
                }


            }
            return true;
        }
    }
}
