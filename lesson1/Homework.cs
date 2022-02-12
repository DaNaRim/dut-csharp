using System;

namespace ConsoleApp1.lesson1 {
    public class Homework {
         // public static void Main(string[] args) {
         //     task2();
         //     task3();
         //     task4();
         //     task5();
         //     task6();
         //     task7();
         //     task8();
         // }
         
         static void task2() {
             bool a = true;
             char b = 'o';
             
             byte c = 1;
             sbyte d = 1;

             short e = 1;

             Console.WriteLine(a);
             Console.WriteLine(b);
             Console.WriteLine(c);
             Console.WriteLine(d);
             Console.WriteLine(e);
         }

         static void task3() {
             const decimal a = 1.0m;
             const double b = 1.99;
             const float c = 1.33f;
             
             Console.WriteLine(a);
             Console.WriteLine(b);
             Console.WriteLine(c);
         }

         static void task4() {
             int a = 3;
             int b = 4;

             Console.WriteLine(a + b);
             Console.WriteLine(a - b);
             Console.WriteLine(a * b);
         }
         
         static void task5() {
             int a = 3;
             int b = 4;
             
             if (a + b > 0) {
                 Console.WriteLine('\u002B');
             } else {
                 Console.WriteLine('\u002D');
             }
         }

         static void task6() {
             string password = Console.ReadLine();

             if (password.Equals("2hg6")) {
                 Console.WriteLine("Доступ 1 рівня");
                 
             } else if (password.Equals("9dbdj393")) {
                 Console.WriteLine("Доступ 2 рівня");
                 
             } else if (password.Equals("94bfkmf;dm9594")) {
                 Console.WriteLine("Доступ 3 рівня");
             } else  {
                 Console.WriteLine("Доступ заборонено");
             }
         }

         static void task7() {
             int[] array = {1, 2, 3, 4, 5};
             var sum = array[0];
             for (int i = 1; i < array.Length; i++) {
                 sum += array[i];
             }
             Console.WriteLine(sum);
         }

         static void task8() {
             string[] fruits = {"peach", "cherry", "apple", "pineapple"};

             foreach (string fruit in fruits) {
                 if (!fruit.Equals("apple")) continue;
                 Console.WriteLine("found");
                 break;
             }
         }
    }
}