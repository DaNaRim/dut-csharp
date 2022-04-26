namespace ConsoleApp1.lesson9.delegators {

    public class MyMathDelegate {

        public delegate int SumDel(int a, int b);
        public delegate int MultiplyDel(int a, int b);

        public static SumDel sumDel = MyMath.Sum;
        public static MultiplyDel multiplyDel = MyMath.Multiply;

    }

}