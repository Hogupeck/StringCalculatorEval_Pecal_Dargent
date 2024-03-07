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

            var contr�le = 2 + 2;

            Assert.Equal(contr�le, result);
        }
    }
}