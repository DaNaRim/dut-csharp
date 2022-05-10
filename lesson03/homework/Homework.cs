using System;

namespace ConsoleApp1.lesson03.homework {
    public class Homework {
        // public static void Main(string[] args) {
        //     Console.WriteLine(MultNums());
        //     Console.WriteLine(OperationsWithNums());
        //     Console.WriteLine(getColor(Fruits.KIVI));
        //
        //     Project project = new("BestName", 20, 100, true);
        //     Project project2 = new("BestName2", 22, 92, false);
        //
        //     project.WriteNameAndMark();
        //     project.WriteNameAndStatus();
        //     project2.WriteNameAndMark();
        //     project2.WriteNameAndStatus();
        // }

        public static int MultNums() {
            return Int32.Parse(Console.ReadLine())
                   * Int32.Parse(Console.ReadLine())
                   * Int32.Parse(Console.ReadLine());
        }

        public static int OperationsWithNums() {
            int[] nums = new int[3];
            for (int i = 0; i < nums.Length; i++) {
                nums[i] = Int32.Parse(Console.ReadLine());
            }

            char operand = Console.ReadLine()[0];
            switch (operand) {
                case '+': return nums[0] + nums[1] + nums[2];
                case '*': return nums[0] * nums[1] * nums[2];
                default: return 0;
            }
        }

        public static string getColor(Fruits fruit) {
            switch (fruit) {
                case Fruits.PAPAYA:
                case Fruits.BANANA: return "yellow";

                case Fruits.APPLE:
                case Fruits.PEACH:
                case Fruits.CHERRY: return "red";

                case Fruits.KIVI: return "brown";
                case Fruits.ORANGE: return "orange";
                default: return "Invalid color";
            }
        }
    }
}