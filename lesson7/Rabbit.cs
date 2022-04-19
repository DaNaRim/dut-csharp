using System;

namespace ConsoleApp1.lesson7 {
    public class Rabbit : Animal {
        
        private int tailLength;

        public Rabbit(int tailLength) {
            this.tailLength = tailLength;
        }

        public override void makeSound() {
            Console.WriteLine("*Rabbit sound*");
        }

        public override void move() {
            Console.WriteLine("*Rabbit jumps far away*");
        }
    }
}