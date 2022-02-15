using System;

namespace ConsoleApp1.lesson3 {
    public class Classwork {
        // public static void Main(string[] args) {
        //
        //     Teacher teacher = new Teacher();
        //     
        //     
        //     // Console.WriteLine(teacher.tname);
        //     Console.WriteLine(teacher.ToString());
        //     
        //     Console.WriteLine(Math.Pow(6, 3));
        // }
    }

    public class Teacher {

        private string tname = "Undefined";
        private string val;
        
        public static void ff() {
            Console.WriteLine("");
        }
        
        public override string ToString() {
            return $"{nameof(tname)}: {tname}, {nameof(val)}: {val}";
        }
        
    }
}
