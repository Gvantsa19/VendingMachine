using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Abstract;

namespace VendingMachine.Products
{
    public class Pepsi : Drink
    {
        private Pepsi() { }
        private static Pepsi _pepsi;

        public static Pepsi GetInstance()
        {
            if (_pepsi == null)
            {
                _pepsi = new Pepsi();
            }
            return _pepsi;
        }
    }
}
