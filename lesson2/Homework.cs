using System;

namespace ConsoleApp1.lesson2 {
    public class Homework {
        // public static void Main(string[] args) {
        //     task2();
        //     task3();
        // }

        static void task2() {
            string[] words = new string[5];
            for (int i = 0; i < words.Length; i++) {
                words[i] = Console.ReadLine();
            }

            foreach (var word in words) {
                Console.Write(word + " ");
            }
        }

        static void task3() {
            string[] words = new string[5];
            for (int i = 0; i < words.Length; i++) {
                words[i] = Console.ReadLine();
            }

            foreach (var word in words) {
                if (word.Equals("password")) {
                    printPassword(word);
                } else {
                    Console.Write(word + " ");
                }
            }
        }

        static void printPassword(string word) {
            foreach (var letter in word.ToCharArray()) {
                Console.Write(letter + " ");
            }
        }
    }
}
