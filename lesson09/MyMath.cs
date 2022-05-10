using System;

namespace ConsoleApp1.lesson09 {

    public class MyMath {

        public static int Sum(int a, int b) => a + b;

        public static int Multiply(int a, int b) {
            if (a == 0 || b == 0) {
                throw new Exception("Argument must be non-zero");
            }
            return a * b;
        }

    }

}