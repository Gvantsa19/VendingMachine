using System;
using System.Collections.Generic;
using VendingMachine.Modules;
using VendingMachine.Products;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Init();

            Distributor.Disp.Run();
        }
        private static void Init()
        {
            // MOCK OBJECTS FOR THE EXERCISE

            Cola.GetInstance().Price = 1;
            Sprite.GetInstance().Price = 1;
            Skittles.GetInstance().Price = 1;
            Smarties.GetInstance().Price = 1;

            Dictionary<DrinkCode, int> d1 = new Dictionary<DrinkCode, int>
            {
                { new DrinkCode(Cola.GetInstance()), 4 },
                { new DrinkCode(Sprite.GetInstance()), 7 }
            };

            Dictionary<DrinkCode, int> d2 = new Dictionary<DrinkCode, int>
            {
                { new DrinkCode(Cola.GetInstance()), 5 },
            };

            Dictionary<DrinkCode, int> d3 = new Dictionary<DrinkCode, int>
            {
                { new DrinkCode(Sprite.GetInstance()), 2 }
            };

            Dictionary<DrinkCode, int> d4 = new Dictionary<DrinkCode, int>
            {
                { new DrinkCode(Cola.GetInstance()), 7 },
                { new DrinkCode(Sprite.GetInstance()), 6 }
            };

            Dictionary<CandyCode, int> c1 = new Dictionary<CandyCode, int>
            {
                { new CandyCode(Skittles.GetInstance()), 4 },
                { new CandyCode(Smarties.GetInstance()), 7 }
            };

            Dictionary<CandyCode, int> c2 = new Dictionary<CandyCode, int>
            {
                { new CandyCode(MandMs.GetInstance()), 5 },
            };

            Dictionary<CandyCode, int> c3 = new Dictionary<CandyCode, int>
            {
                { new CandyCode(Smarties.GetInstance()), 2 }
            };

            Dictionary<CandyCode, int> c4 = new Dictionary<CandyCode, int>
            {
                { new CandyCode(Skittles.GetInstance()), 7 },
                { new CandyCode(MandMs.GetInstance()), 6 }
            };

            Distributor.Stock.Add(d1);
            Distributor.Stock.Add(d2);
            Distributor.Stock.Add(d3);
            Distributor.Stock.Add(d4);

            Distributor.Stock2.Add(c1);
            Distributor.Stock2.Add(c2);
            Distributor.Stock2.Add(c3);
            Distributor.Stock2.Add(c4);
        }
    }
}
