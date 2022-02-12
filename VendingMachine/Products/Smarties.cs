using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Abstract;

namespace VendingMachine.Products
{
    public class Smarties : Candy
    {
        private Smarties() { }
        private static Smarties smarties;

        public static Smarties GetInstance()
        {
            if (smarties == null)
            {
                smarties = new Smarties();
            }
            return smarties;
        }
    }
}
