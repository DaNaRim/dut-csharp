using System;

namespace ConsoleApp1.lesson07 {
    public class Goat : Animal {

        private long secretMilitaryId;

        public Goat(long secretMilitaryId) {
            this.secretMilitaryId = secretMilitaryId;
        }

        public override void makeSound() {
            Console.WriteLine("Beeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee" +
                              "eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeoooo");
        }

        public override void move() {
            Console.WriteLine("Angry run");
        }
    }
}