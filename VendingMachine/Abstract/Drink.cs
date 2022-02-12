using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Abstract
{
    public class Drink
    {
        // Factory Pattern so all the drinks possess the same interface

        private double price;

        public double Price { get => price; set => SetPrice(value); }

        private void SetPrice(double value)
        {
            this.price = value;
        }
    }
}
