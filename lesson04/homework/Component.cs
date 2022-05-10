using System;

namespace ConsoleApp1.lesson04.homework {
    public struct Component {
        private string name;
        private string fieldOfApplication;
        private int countPins;

        public Component(string name, string fieldOfApplication, int countPins) {
            this.name = name;
            this.fieldOfApplication = fieldOfApplication;
            this.countPins = countPins;
        }

        public void PrintAllFields() {
            Console.WriteLine($"{nameof(name)}: {name}, " +
                              $"{nameof(fieldOfApplication)}: {fieldOfApplication}, " +
                              $"{nameof(countPins)}: {countPins}");
        }

        public void PrintNameAndCountPins() {
            Console.WriteLine($"{nameof(name)}: {name}, " +
                              $"{nameof(countPins)}: {countPins}");
        }
    }
}