using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorEval
{
    public class StringCalculatorEval
    {
        public static int Parse(string input)
        {
            var parts = input.Split(',');

            var numbers = parts
                .Select(str => str.Replace(" ", ""))
                .Select(int.Parse)
                .Sum();

            return numbers;
        }
    }
}
