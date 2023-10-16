using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMove
{
    internal class Car : Vehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine is running.");
        }
        public void StopEngine()
        {
            Console.WriteLine("Engine is not running.");
        }
    }

}
