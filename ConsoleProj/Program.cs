using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProj
{
    class Program
    {
        static void Main(string[] args)
        {
            HYBargainRequire bargainRequire = new HYBargainRequire()
            {
                Money = 2000,
                DisCountMoney = 0,
                BargainRule = new BargainRule() {
                    BargainMaxPricePercent = 0.1,
                    BargainLimitPricePercent = 0.1,

                }

            };

            Bargainer bargainer = new Bargainer();

            double bargainMoney = 0;
            bool bargainResult = false;
            do
            {
                bargainResult = bargainer.Bargain(bargainRequire, out bargainMoney);
                if(bargainResult)
                {
                     
                    bargainRequire.DisCountMoney += bargainMoney;
                    string res = string.Format("订单总价{0}元，累计砍价{1}元，本次砍价{2}元", bargainRequire.Money,
                        bargainRequire.DisCountMoney, bargainMoney);

                    Console.WriteLine(res);
                    Console.ReadKey();
                }
                

            } while (bargainResult);

            Console.ReadKey();

        }
    }
}
