using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        public float Number1;
        public float Number2;
        public Calculator(float n1, float n2)
        {
            Number1 = n1;
            Number2 = n2;
        }
        public float Addition()
        {
            return Number1+Number2;
        }
        public float Subtraction()
        {
            return Number1-Number2;
        }
        public float Multiplication()
        {
            return Number1*Number2;
        }
        public float Division()
        {
            return Number1/Number2;
        }
    }
}
