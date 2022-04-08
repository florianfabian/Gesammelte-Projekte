using Xunit;
using Kleine_Zahlentheorie;

namespace TestProjektZahlentheorie
{
    public class UnitTestTheory
    {
        [Theory]
        [InlineData(35, 49, 7)]
        [InlineData(72, 49, 1)]
        [InlineData(49, 35, 7)]
        [InlineData(35, 35, 35)]
        [InlineData(35, 0, 35)]
        [InlineData(0, 49, 49)]
        [InlineData(0, 0, 0)]
        [InlineData(-35, 49, 7)]
        [InlineData(-35, -49, 7)]
        public void TestBerechneGGT(int a, int b, int expected)
        {
            Assert.Equal(expected, Zahlentheorie.BerechneGGT(a, b));
        }
    }
}
