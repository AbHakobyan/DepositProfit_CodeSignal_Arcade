using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositProfit_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d = 100;
            int r = 20;
            int t = 170;
            int res = depositProfit(d, r, t);
            Console.WriteLine(res);
        }

        static int depositProfit(int deposit, int rate, int threshold)
        {
            int count = 0;
            while(deposit < threshold)
            {
                deposit = ((deposit * rate) / 100 ) + deposit;
                count++;
            }    
            return count;
        }
    }
}
