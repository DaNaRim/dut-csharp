using System;

namespace ConsoleApp1.lesson6 {
    public struct Hobbies {
        private HobbiesName name;
        private int popularityRating;
        private int yearsOfExperience;

        public Hobbies(HobbiesName name, int popularityRating, int yearsOfExperience) {
            this.name = name;
            this.popularityRating = popularityRating;
            this.yearsOfExperience = yearsOfExperience;
        }

        public void printName() {
            Console.WriteLine("name: " + name);
        }

        public void printNameAndPopularityRating() {
            Console.WriteLine("name: " + name + ", popularity rating: " + popularityRating);
        }

        public void printNameAndYearsOfExperience() {
            Console.WriteLine("name: " + name + ", years of experience " + yearsOfExperience);
        }
    }
}