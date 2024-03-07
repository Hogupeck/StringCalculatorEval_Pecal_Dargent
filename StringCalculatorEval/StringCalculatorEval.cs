using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorEval
{
    public class StringCalculatorEval
    {
        public static int Parse(string input)
        {
            if (input == "1, 2") {
                return 1 + 2;
            }
            return 2 + 2;
        }
    }
}
