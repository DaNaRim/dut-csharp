using System;

namespace ConsoleApp1.lesson1 {
    public class Classwork {
        // public static void Main(string[] args) {
        //     run();
        // }
        
        static void run() {
            Console.WriteLine("Hello, World!3");
            Console.Write(9 > 10);

            byte b = 9;
            Console.Write(b);
            b = 5;
            Console.WriteLine(b);

            float f = 7.3f;
            double d = 5.4;
            char z = (char) 63;
            Console.WriteLine(z);

            string str = "ff";
            Console.WriteLine(str);

            const int co = 5;

            void doubleText(string str) {
                Console.WriteLine(str + str);
            }

            doubleText("ddddddd");

            const string w1 = "word1";
            const string w2 = "word2";

            doubleText(w1);
            doubleText(w2);

            string[] students = new string[5];
            string[] students2 = {"Anna", "Nazar", "Zhenya", "Kolya", "Ilona"};

            students[0] = "anna";
            Console.WriteLine(students[3]);
            Console.WriteLine(students2);

            students2[2] = "Evgeniy";
            Console.WriteLine(students2[2]);

            string[,] students3 = {{"Anna", "5"}, {"dd", "dd"}};
            Console.WriteLine(students3[1, 1]);

            Console.WriteLine(string.Join("\n", students2));

            for (int i = 0; i < students2.Length; i++) {
                if (students2[i] == "Anna") {
                    Console.WriteLine("Cached!");
                    break;
                } else {
                    Console.WriteLine("not found");
                }
            }
        }
    }
}