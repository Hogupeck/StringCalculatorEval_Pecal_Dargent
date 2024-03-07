namespace StringCalculatorEvalTest
{
    public class StringCalculatorEvalTest
    {
        [Fact]
        public void APlusB1()
        {
            const string input = "1, 2";

            var result =
                StringCalculatorEval.StringCalculatorEval.Parse(input);

            var contr�le = 1 + 2;

            Assert.Equal(contr�le, result);
        }
        [Fact]
        public void APlusB2()
        {
            const string input = "2, 2";

            var result =
                StringCalculatorEval.StringCalculatorEval.Parse(input);

        [Theory]
        [MemberData(nameof(CasAPlusB))]
        public void APlusB(params int[] parts)
        {
            var input = string.Join(',', parts);
            var result = StringCalculatorEval.StringCalculatorEval.Parse(input);
            var contr�le = parts.First() + parts.Last();

            Assert.Equal(parts.Sum(), result);
        }
    }
}