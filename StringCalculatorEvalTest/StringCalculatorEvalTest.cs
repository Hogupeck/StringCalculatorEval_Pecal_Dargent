using System.IO;

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
        }

        [Theory]
        [MemberData(nameof(CasAPlusB))]
        public void APlusB(params int[] parts)
        {
            var input = string.Join(',', parts);
            var result = StringCalculatorEval.StringCalculatorEval.Parse(input);

            Assert.Equal(parts.Sum(), result);
        }
    }
}