using System.IO;
using StringCalculatorEval;

namespace StringCalculatorEvalTest
{
    public class StringCalculatorEvalTest
    {
        public static IEnumerable<object[]> CasAPlusB()
        {
            yield return [0, 0];
            yield return [1, 0];
            yield return [0, 1];
            yield return [2, 0];
            yield return [1, 2];
            yield return [1, 2, 1];
        }

        [Theory]
        [MemberData(nameof(CasAPlusB))]
        public void APlusB(params int[] parts)
        {
            var input = string.Join(',', parts);
            var result = StringCalculatorEval.StringCalculatorEval.Parse(input);

            Assert.Equal(parts.Sum(), result);
        }

        [Fact]
        public void Espaces()
        {
            const string test�e = "1 0, 1 0  ";

            var result =
                StringCalculatorEval.StringCalculatorEval.Parse(test�e);

            var contr�le = StringCalculatorEval.StringCalculatorEval.Parse(
                test�e.Replace(" ", "")
            );

            Assert.Equal(contr�le, result);
        }
        [Fact]
        public void NegatifsInterdits()
        {
            const string test�e = "-1";

            void Act() => StringCalculatorEval.StringCalculatorEval.Parse(test�e);

            var exception = Assert.Throws<NombreNegatifException>(Act);
            Assert.Equal(0, exception.Position);
            Assert.Equal(-1, exception.NombreFautif);
        }
    }
}