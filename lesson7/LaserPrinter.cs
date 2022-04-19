using System;

namespace ConsoleApp1.lesson7 {
    public class LaserPrinter : Printer {
        private string[] supportedOs;
        private int printingSpeed;

        public LaserPrinter(string model,
            string yearOfManufacturing,
            bool hasCiss,
            int warrantyPeriodInYears,
            string[] supportedOs,
            int printingSpeed) : base(model, yearOfManufacturing, hasCiss, warrantyPeriodInYears) {
            this.supportedOs = supportedOs;
            this.printingSpeed = printingSpeed;
        }

        public void PrintNameAndPrintingSpeed() {
            Console.WriteLine($"{nameof(model)}: {model}, {nameof(printingSpeed)}: {printingSpeed}");
        }

        public void PrintYearOfManufacturingAndSupportedOs() {
            Console.WriteLine($"{nameof(yearOfManufacturing)}: {yearOfManufacturing}," +
                              $" {nameof(supportedOs)}: [{String.Join(", ", supportedOs)}]");
        }
    }
}