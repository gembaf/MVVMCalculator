using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMCalculator.Model
{
    public class Function
    {
        public double Left { get; set; }

        public double Right { get; set; }

        public Calculator.Type CalculateType { get; set; }

        public double Calculate()
        {
            Calculator calc = new Calculator();
            return calc.Execute(Left, Right, CalculateType);
        }
    }
}
