using System;
using ConsoleApp1.lesson9.delegators;

namespace ConsoleApp1.lesson9 {

    public class Program {

        public static void Main(string[] args) {
            WelcomeDelegate.sayHelloDel.Invoke();

            MyTextDelegate.printTextTwiceDel.Invoke("abc");
            Console.WriteLine(MyTextDelegate.getFirstSignDel.Invoke("abc"));

            Console.WriteLine(MyMathDelegate.sumDel.Invoke(1, 2));
            Console.WriteLine(MyMathDelegate.multiplyDel.Invoke(1, 2));
        }

    }

}