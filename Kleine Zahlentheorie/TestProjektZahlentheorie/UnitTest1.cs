using Xunit;
using Kleine_Zahlentheorie;

namespace TestProjektZahlentheorie
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int a = 35;
            int b = 49;
            int expected = 7;
            int ggt = Zahlentheorie.BerechneGGT(a, b);

            Assert.Equal(expected, ggt);
        }
        [Fact]
        public void Test2()
        {
            int a = 72;
            int b = 49;
            int expected = 1;
            int ggt = Zahlentheorie.BerechneGGT(a, b);

            Assert.Equal(expected, ggt);
        }
    }
}