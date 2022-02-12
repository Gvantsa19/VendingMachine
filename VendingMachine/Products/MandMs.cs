using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Abstract;

namespace VendingMachine.Products
{
    public class MandMs : Candy
    {
        private MandMs() { }
        private static MandMs _mNms;

        public static MandMs GetInstance()
        {
            if (_mNms == null)
            {
                _mNms = new MandMs();
            }
            return _mNms;
        }
    }
}
