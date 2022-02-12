using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Abstract;

namespace VendingMachine.Products
{
    public class Skittles : Candy
    {
        private Skittles() { }
        private static Skittles skittles;

        public static Skittles GetInstance()
        {
            if (skittles == null)
            {
                skittles = new Skittles();
            }
            return skittles;
        }
    }
}
