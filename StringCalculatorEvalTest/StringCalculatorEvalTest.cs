namespace StringCalculatorEvalTest
{
    public class StringCalculatorEvalTest
    {
        [Fact]
        public void APlusB1()
        {
            const string test�e = "1, 2";

            var result =
                StringCalculatorEval.StringCalculatorEval.Parse();

            var contr�le = 1 + 2;

            Assert.Equal(contr�le, result);
        }
        [Fact]
        public void APlusB2()
        {
            const string test�e = "2, 2";

            var result =
                StringCalculatorEval.StringCalculatorEval.Parse();

            var contr�le = 2 + 2;

            Assert.Equal(contr�le, result);
        }
    }
}