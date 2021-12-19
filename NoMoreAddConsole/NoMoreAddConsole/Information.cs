using System;
using System.Collections.Generic;
using System.Text;

namespace NoMoreAddConsole
{
    class Information
    {
        private string _DDI, _DDD, _Number;
        public string CatchDDI()
        {
            Console.WriteLine("Type the DDI:");
            _DDI = Console.ReadLine();
            return _DDI;
        }

        public string CatchDDD()
        {
            Console.WriteLine("Type the DDD:");
            _DDD = Console.ReadLine();
            return _DDD;
        }

        public string CatchNumber()
        {
            Console.WriteLine("Type the number:");
            _Number = Console.ReadLine();
            return _Number;
        }
    }
}
