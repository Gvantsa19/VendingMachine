using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VendingMachine.Abstract;
namespace VendingMachine.Products
{
    public class Water : Drink
    {
        private Water()
        {
        }
        private static Water _water; public static Water GetInstance()
        {
            if (_water == null)
            {
                _water = new Water();
            }
            return _water;
        }
    }
}
