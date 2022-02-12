using System;
using System.Collections.Generic;
using VendingMachine.Modules;
using VendingMachine.Products;
using VendingMachine.Start;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProgram.Init();

            Distributor.Disp.Run();
        }
        
    }
}
