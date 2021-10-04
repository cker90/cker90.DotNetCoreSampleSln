using System;

namespace StaticLibrary
{

    // 数学运算静态类
    public static class MathOperation
    {
        // 这是一个两个数字的简单加法的方法
        public static int Add(int num1, int num2) => num1 + num2;
        //这是一个两个数字的简单减法的方法
        public static int Subtract(int num1, int num2) => num1 - num2;
        //这是一个两个数字的简单乘法的方法
        public static int Multiply(int num1, int num2) => num1 * num2;
        //这是一个两个数字的简单除法的方法
        public static int Divide(int num1, int num2) => num1 / num2;
    }
}
