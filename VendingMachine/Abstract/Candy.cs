using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Abstract
{
    public class Candy
    {
        private double price;

        public double Price { get => price; set => SetPrice(value); }

        private void SetPrice(double value)
        {
            this.price = value;
        }
    }
}
