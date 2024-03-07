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

            var contrôle = 1 + 2;

            Assert.Equal(contrôle, result);
        }
        [Fact]
        public void APlusB2()
        {
            const string input = "2, 2";

            var result =
                StringCalculatorEval.StringCalculatorEval.Parse(input);

            var contrôle = 2 + 2;

            Assert.Equal(contrôle, result);
        }
    }
}