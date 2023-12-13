using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CalculateImpl : ICalculate
    {
        public int add(int valuea, int valueb)
        {
            return valuea + valueb;
        }
    }
}
