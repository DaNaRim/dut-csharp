using System;

namespace ConsoleApp1.lesson7 {
    public class Cat : Animal {

        private int livesCount;

        public Cat(int livesCount) {
            this.livesCount = livesCount;
        }

        public override void makeSound() {
            Console.WriteLine("Meow");
        }

        public override void move() {
            Console.WriteLine("*Cat walks*");
        }
    }
}