using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VendingMachine.Abstract;
namespace VendingMachine.Products
{
    public class Sprite : Drink
    {
        private Sprite()
        {
        }
        private static Sprite _sprite; public static Sprite GetInstance()
        {
            if (_sprite == null)
            {
                _sprite = new Sprite();
            }
            return _sprite;
        }
    }
}
