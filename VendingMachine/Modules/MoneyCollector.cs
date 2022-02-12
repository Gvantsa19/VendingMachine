using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Modules
{

    public class MoneyCollector
    {
        protected int twenty = 0;
        protected int fifty = 0;
        protected int one = 0;
        protected int two = 0;
        protected int five = 0;

        protected static int totalMoney;

        public int TotalMoney { get => Total(); }
        public double TotalMoneyInDouble { get => (double)TotalMoney / 100; }

        public MoneyCollector()
        {

        }

        private int Total()
        {
            int sum = (twenty * 20) + (fifty * 50) + (one * 100) + (two * 200) + (five * 500);
            totalMoney = sum;
            return sum;
        }

        public string Show()
        {
            string res = "";
            if (five != 0) res += "\t- " + five + " time 5 dollar\n";
            if (two != 0) res += "\t- " + two + " time 2 dollar\n";
            if (one != 0) res += "\t- " + one + " time 1 dollar\n";
            if (fifty != 0) res += "\t- " + fifty + " time 50 cents\n";
            if (twenty != 0) res += "\t- " + twenty + " time 20 cents\n";
            return res;
        }

        public void Insert(Money coin)
        {
            switch (coin)
            {
                case Money.FiveDollar:
                    five++;
                    break;
                case Money.TwoDollar:
                    two++;
                    break;
                case Money.OneDollar:
                    one++;
                    break;
                case Money.FiftyCent:
                    fifty++;
                    break;
                case Money.TwenyCent:
                    twenty++;
                    break;
            }
        }

        public Dictionary<Money, int> GetChange(int price)
        {
            int money = TotalMoney - price;
            Dictionary<Money, int> getChange = new Dictionary<Money, int>();

            while (money != 0)
            {
                if (money >= 200)
                {
                    money -= 200;
                    if (getChange.ContainsKey(Money.TwoDollar))
                    {
                        getChange[Money.TwoDollar]++;
                    }
                    else
                    {
                        getChange.Add(Money.TwoDollar, 1);
                    }
                }
                else if (money >= 500)
                {
                    money -= 500;
                    if (getChange.ContainsKey(Money.FiveDollar))
                    {
                        getChange[Money.FiveDollar]++;
                    }
                    else
                    {
                        getChange.Add(Money.FiveDollar, 1);

                    }
                }
                else if (money >= 100)
                {
                    money -= 100;
                    if (getChange.ContainsKey(Money.OneDollar))
                    {
                        getChange[Money.OneDollar]++;
                    }
                    else
                    {
                        getChange.Add(Money.OneDollar, 1);

                    }
                }
                else if (money >= 50)
                {
                    money -= 50;
                    if (getChange.ContainsKey(Money.FiftyCent))
                    {
                        getChange[Money.FiftyCent]++;
                    }
                    else
                    {
                        getChange.Add(Money.FiftyCent, 1);

                    }
                }
                else if (money >= 20)
                {
                    money -= 20;
                    if (getChange.ContainsKey(Money.TwenyCent))
                    {
                        getChange[Money.TwenyCent]++;
                    }
                    else
                    {
                        getChange.Add(Money.TwenyCent, 1);

                    }
                }
            }
            return getChange;
        }
    }
}
