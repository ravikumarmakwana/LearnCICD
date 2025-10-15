using LearnCICD.Services;

namespace LearnCICD.Tests
{
    public class CalculatorServiceTests
    {
        private readonly CalculatorService _calculatorService;
        public CalculatorServiceTests()
        {
            _calculatorService = new CalculatorService();
        }

        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(20, 30, 50)]
        public void Add_ShouldReturnSum(int a, int b, int sum)
        {
            var result = _calculatorService.Add(a, b);
            Assert.Equal(sum, result);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(30, 20, 10)]
        public void Subtract_ShouldReturnDifference(int a, int b, int difference)
        {
            var result = _calculatorService.Subtract(a, b);
            Assert.Equal(difference, result);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(20, 30, 600)]
        public void Multiply_ShouldReturnProduct(int a, int b, int product)
        {
            var result = _calculatorService.Multiply(a, b);
            Assert.Equal(product, result);
        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(20, 4, 5)]
        [InlineData(20, 0, 5)]
        public void Divide_ShouldReturnQuotient(int a, int b, double quotient)
        {
            var result = _calculatorService.Divide(a, b);
            Assert.Equal(quotient, result);
        }

        [Fact]
        public void Divide_ByZero_ShouldThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculatorService.Divide(10, 0));
        }
    }
}
