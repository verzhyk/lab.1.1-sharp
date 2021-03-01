using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_1_sharp
{
    public class FloatPower
    {
        public int First { get; set; }
        public int Second { get; set; }

        public FloatPower(int first, int second)
        {
            if (first > 0) First = first;
            else First = 1;
            if (second > 0) Second = second;
            else Second = 1;
        }

        public int Power()
        {
            if (First > 0 && Second > 0)
            {
                int result = 1;
                for (int i = 0; i < Second; i++)
                {
                    result *= First;
                }
                return result;
            }
            else return 0;
        }
    }
}
