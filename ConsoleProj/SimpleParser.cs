using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProj
{
    public class SimpleParser
    {
        public int ParseAndSum(string numbers)
        {
            if(numbers.Length == 0)
            {
                return 0;
            }
            
            if(!numbers.Contains(","))
            {
                return int.Parse(numbers);
            }
            else
            {
                throw new InvalidOperationException("目前只能接受数字0或1！");
            }
        }
    }
}
