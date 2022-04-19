using System;

namespace ConsoleApp1.lesson7 {
    public class Printer {

        protected string model;
        protected string yearOfManufacturing;
        private bool hasCiss;
        private int warrantyPeriodInYears;


        public Printer(string model, string yearOfManufacturing, bool hasCiss, int warrantyPeriodInYears) {
            this.model = model;
            this.yearOfManufacturing = yearOfManufacturing;
            this.hasCiss = hasCiss;
            this.warrantyPeriodInYears = warrantyPeriodInYears;
        }

        public void PrintNameAndYearOfManufacturing() {
            Console.WriteLine($"{nameof(model)}: {model}, {nameof(yearOfManufacturing)}: {yearOfManufacturing}");
        }
        
        public void PrintNameAndWarrantyPeriod() {
            Console.WriteLine($"{nameof(model)}: {model}, {nameof(warrantyPeriodInYears)}: {warrantyPeriodInYears}");
        }
    }
}