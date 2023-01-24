namespace Summator.NunitTests
{
    public class SummatorTests
    {

        [Test]
        public void Test_Summator_SumTwoPositiveNumbers()
        {
            var nums = new int[] { 4, 6 };
            var actual = Summator.Sum(nums);

            var expected = 10;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_SumTwoNegativeNumbers()
        {
            var nums = new int[] { -9, -18 };
            var actual = Summator.Sum(nums);

            var expected = -27;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_OneNumber()
        {
            var nums = new int[] { 4 };
            var actual = Summator.Sum(nums);

            var expected = 4;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_Zero()
        {
            var nums = new int[] { 0 };
            var actual = Summator.Sum(nums);

            var expected = 0;

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Test_AverigeEqualsNumber()
        {
            var nums = new int[] { 2, 2, 2 };
            var actual = Summator.Average(nums);

            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_AverageNegativeNumbers()
        {
            var nums = new int[] { -40, -10, -10 };
            var actual = Summator.Average(nums);

            var expected = -20;

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Test_AverageDoubleNumbers()
        {
            var nums = new int[] { 4, 8, 5, 6 };
            var actual = Summator.Average(nums);

            var expected = 5.75;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_AverageNumbersAddZero()
        {
            var nums = new int[] { 5, 0, 1, 4, 5 };
            var actual = Summator.Average(nums);

            var expected = 3;

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Test_AveragePositiveNegative()
        {
            var nums = new int[] { -6, 1, -7, 0, 3 };
            var actual = Summator.Average(nums);

            var expected = -1.8;

            Assert.AreEqual(expected, actual);

        }
    }
}

