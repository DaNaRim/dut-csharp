using System;

namespace ConsoleApp1.lesson8 {
    public class Demo {
        // public static void Main(string[] args) {
        //     double fahrenheit = ConvertCelsiusToFahrenheit(Console.ReadLine());
        //     Console.WriteLine(fahrenheit);
        //
        //     checkPasswordLength(Console.ReadLine());
        // }

        public static double ConvertCelsiusToFahrenheit(string temperature) {
            double celsius;
            try {
                celsius = double.Parse(temperature);
            } catch (Exception) {
                throw new Exception("temperature filled incorrect");
            }
            // if (celsius > 300) throw new TooHotException("To hot");
            // if (celsius < 300) throw new TooColdException("To cold");
            
            if (celsius < -273.15) {
                throw new Exception("temperature must be greater than Absolute Zero (-273.15)");
            }
            double fahrenheit = celsius * 1.8 + 32;
            return Math.Round(fahrenheit, 2);
        }

        public static void checkPasswordLength(string password) {
            if (password.Length > 8) {
                throw new TooLongPasswordException("Password is too long");
            }
        }
    }
}