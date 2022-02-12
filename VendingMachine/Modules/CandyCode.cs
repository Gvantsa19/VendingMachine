using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Abstract;

namespace VendingMachine.Modules
{
    public class CandyCode
    {
        public Candy candy;
        static int iterator = 0;
        public int Code { get; }

        public CandyCode()
        {

        }

        public CandyCode(Candy _candy)
        {
            this.candy = _candy;
            Code = iterator;
            iterator++;
        }
    }
}
