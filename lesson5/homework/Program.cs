using System;

namespace ConsoleApp1.lesson5.homework {
    public class Program {
        // public static void Main() {
        //     Task1();
        //     Task2();
        //     Task3();
        // }

        private static void Task1() {
            string? name;
            string? age;

            do {
                Console.Write("Your name:");
                name = Console.ReadLine();
            } while (name is not "Andriy");

            do {
                Console.Write("Your age: ");
                age = Console.ReadLine();
            } while (age is not "25");

            Console.WriteLine("Caught!");
        }

        private static void Task2() {
            Console.Write("Write card id: ");
            string? cardId = Console.ReadLine();

            switch (cardId) {
                case "9504ngg":
                    Console.WriteLine("Open all");
                    break;
                case "ndd9y4":
                    Console.WriteLine("Open 1 floor");
                    break;
                case "nmvl55d96":
                    Console.WriteLine("Open 2 floor");
                    break;
                default:
                    Console.WriteLine("Block card and close all");
                    break;
            }
        }

        private static void Task3() {
            Console.Write("First number: ");
            int num1 = int.Parse(Console.ReadLine()!);

            Console.Write("Second number: ");
            int num2 = int.Parse(Console.ReadLine()!);

            Console.Write("Third number: ");
            int num3 = int.Parse(Console.ReadLine()!);

            if (num1 == 0 || num2 == 0 || num3 == 0) {
                Console.WriteLine("I'm going to divide you by zero myself >:");
                return;
            }
            Console.WriteLine(dNums(num1, num2, num3) * 10);
        }

        private static int dNums(int num1, int num2, int num3) {
            //Без внятного ТЗ - результат ХЗ
            return num1 / num2 / num3;
        }
    }
}