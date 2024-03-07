namespace StringCalculatorEvalTest
{
    public class StringCalculatorEvalTest
    {
        [Fact]
        public void APlusB1()
        {
            const string testée = "1, 2";

            var result =
                StringCalculatorEval.StringCalculatorEval.Parse();

            var contrôle = 1 + 2;

            Assert.Equal(contrôle, result);
        }
        [Fact]
        public void APlusB2()
        {
            const string testée = "2, 2";

            var result =
                StringCalculatorEval.StringCalculatorEval.Parse();

            var contrôle = 2 + 2;

            Assert.Equal(contrôle, result);
        }
    }
}