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

            Distributor.Stock.Add(d1);
            Distributor.Stock.Add(d2);
            Distributor.Stock.Add(d3);
            Distributor.Stock.Add(d4);
        }
    }
}
