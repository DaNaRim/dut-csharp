using System;

namespace ConsoleApp1.lesson9 {

    public class MyText {

        public static void PrintTextTwice(string text) {
            if (text.Length > 10) {
                throw new Exception("text must be less than 10");
            }
            Console.WriteLine(text + text);
        }

        public static char GetFirstSign(string text) => text[0];

    }

}