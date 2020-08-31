using System;
using System.Data;

namespace MyCalc.Core.Calculators
{
    public class ExpressionCalculator : ICalculator
    {
        public double Calculate(string expression)
        {
            var dataTable = new DataTable();
            var value = dataTable.Compute(expression, "");
            return Convert.ToDouble(value);
        }
    }
}
