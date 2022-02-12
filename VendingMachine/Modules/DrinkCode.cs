using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Abstract;

namespace VendingMachine.Modules
{
    public class DrinkCode
    {
        public Drink drink;
        static int iterator = 0;
        public int Code { get; }

        public DrinkCode()
        {

        }

        public DrinkCode(Drink _drink)
        {
            this.drink = _drink;
            Code = iterator;
            iterator++;
        }
    }
}
