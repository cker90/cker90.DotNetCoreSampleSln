using System;
using Xunit;

namespace XUnitTests
{
    //为静态类库 数学运算类下的方法  添加一些测试
    public class OperationTests
    {
        [Fact]
        public void Test1()
        {

        }
        //这是一个求和方法测试
        [Fact]
        public void AddTwoNumbers_ReturnsSum()
        {
            var num1 = 10;
            var num2 = 20;
            var result = MathOperation.Add(num1, num2);
            Assert.Equal(30, result);
        }
        //这是一个减法方法测试
        [Fact]
        public void SubtractTwoNumbers_ReturnsDifference()
        {
            var num1 = 20;
            var num2 = 10;
            var result = MathOperation.Subtract(num1, num2);
            Assert.Equal(10, result);
        }

        //这是一个乘法方法测试
        [Fact]
        public void MultiplyTwoNumbers_ReturnsProduct()
        {
            var num1 = 10;
            var num2 = 20;
            var result = MathOperation.Multiply(num1, num2);
            Assert.Equal(200, result);
        }
        //这是一个除法方法测试
        [Fact]
        public void DivideTwoNumbers_ReturnsQuotient()
        {
            var num1 = 20;
            var num2 = 10;
            var result = MathOperation.Divide(num1, num2);
            Assert.Equal(2, result);
        }
    }
}
