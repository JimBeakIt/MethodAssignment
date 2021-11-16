using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class Operator
    {
        public double GetAdd(int data)
        {
            data = data + 7;
            return GetSubtract(data);
        }

        private double GetSubtract(double data)
        {
            data = data - 4;
            return GetDivide(data);
        }

        private double GetDivide(double data)
        {
            return data / 2;
        }
    }
}
