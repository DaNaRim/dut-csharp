using System;

namespace ConsoleApp1.lesson04 {
    public class Scamer {
        public string name;
        public byte age;
        public string sp;
        public bool status;

        public void printAllInfo() {
            Console.WriteLine(name + age + sp + status);
        }

        public void printName() {
            Console.WriteLine(name);
        }
    }
}