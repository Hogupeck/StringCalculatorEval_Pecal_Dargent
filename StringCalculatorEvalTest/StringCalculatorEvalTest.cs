using System.IO;

namespace StringCalculatorEvalTest
{
    public class StringCalculatorEvalTest
    {
        public static IEnumerable<object[]> CasAPlusB()
        {
            yield return [1, 2];
            yield return [2, 2];
        }

        [Theory]
        [MemberData(nameof(CasAPlusB))]
        public void APlusB(params int[] parts)
        {
            var input = string.Join(',', parts);
            var result = StringCalculatorEval.StringCalculatorEval.Parse(input);
            var contrôle = parts.First() + parts.Last();

            Assert.Equal(contrôle, result);
        }
    }
}