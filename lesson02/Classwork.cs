using System;

namespace ConsoleApp1.lesson02 {
    public class Classwork {
        /*public static void Main(string[] args) {

            string[] listOfSt = {"Zhenya", "Dima", "Ilona", "Maryana", "German"};
            // SearchInArray("Andrey", listOfSt);

            SecretWord();
            
        }*/

        public static void SearchInArray(string word, string[] array) {
            bool isExist = false;
            foreach (string element in array) {
                if (word == element) {
                    isExist = true;
                    break;
                }
            }
            if (isExist) {
                Console.WriteLine("found");
            } else {
                Console.WriteLine("not found");
            }
        }

        public static void SecretWord() {
            String[] words = {"one", "two", "three", "four", "secret"};

            foreach (string word in words) {
                if (word == "secret") {
                    Console.WriteLine("NO secret");
                    break;
                }
            }
        }
    }
}