using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_1_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            FloatPower floatPower = new FloatPower(10, 2);
            Console.WriteLine(floatPower.Power());
        }
    }
}
