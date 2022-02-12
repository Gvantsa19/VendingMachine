using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Modules
{
    public class Distributor
    {
        static List<Dictionary<DrinkCode, int>> stock = new List<Dictionary<DrinkCode, int>>();
        static List<Dictionary<CandyCode, int>> stock2 = new List<Dictionary<CandyCode, int>>();
        public static List<Dictionary<DrinkCode, int>> Stock { get => stock; set => stock = value; }
        public static List<Dictionary<CandyCode, int>> Stock2 { get => stock2; set => stock2 = value; }

        // A money collector
        static MoneyCollector mc = new MoneyCollector();
        public static MoneyCollector Collector { get => mc; }

        public static void ResetMoneyCollector()
        {
            mc = new MoneyCollector();
        }

        // A display
        static Display disp = new Display();
        public static Display Disp { get => disp; }
    }
}
