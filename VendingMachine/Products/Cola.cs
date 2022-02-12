using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Abstract;

namespace VendingMachine.Products
{
    public class Cola : Drink
    {
        private Cola() { }
        private static Cola _cola;

        public static Cola GetInstance()
        {
            if (_cola == null)
            {
                _cola = new Cola();
            }
            return _cola;
        }
    }
}
