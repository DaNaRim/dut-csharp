using System;

namespace ConsoleApp1.lesson04 {
    public struct Rabbit {
        public byte age;
        public string name;
        public bool color;

        public string getName() {
            return (name);
        }

        public string getNameAge(){
            return(name + age.ToString());
        }

        public void getColor() {
            Console.WriteLine(color);
        }
    }
}