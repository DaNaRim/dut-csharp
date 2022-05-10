using System;

namespace ConsoleApp1.lesson06 {
    public class Classmates {
        private string name;
        private int age;
        private string status;

        public Classmates(string name, int age, string status) {
            this.name = name;
            this.age = age;
            this.status = status;
        }

        public void printName() {
            Console.WriteLine("name: " + name);
        }

        public void printNameAndAge() {
            Console.WriteLine("name: " + name + ", date of birth: " + (DateTime.Now.Year - age));
        }

        public void printNameAndStatus() {
            Console.WriteLine("name: " + name + ", status: " + status);
        }
    }
}