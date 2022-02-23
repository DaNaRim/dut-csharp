using System;

namespace ConsoleApp1.lesson4 {
    public class Program {
    //     public static void Main(string[] args) {
    //         Scamer Dima = new Scamer {
    //             name = "Dima",
    //             age = 18,
    //             sp = "Avito",
    //             status = true
    //         };
    //
    //         Dima.printAllInfo();
    //         Dima.printName();
    //
    //         Rabbit lucy = new Rabbit {
    //             age = 2,
    //             name = "Lucy",
    //             color = true
    //         };
    //         Console.WriteLine(lucy.getNameAge());
    //     }
    }

    namespace Birds {
        public class Sparrow {
            public int age;
            public string name;
            public bool color;

            public string getName() {
                return (name);
            }

            public string getNameAge() {
                return (name + age.ToString());
            }

            public void getColor() {
                Console.WriteLine(color);
            }

            public class Tit {
                public int age;
                public string name;
                public string color;

                public string getName() {
                    return (name);
                }

                public string getNameAge() {
                    return (name + age.ToString());
                }

                public void getColor() {
                    Console.WriteLine(color);
                }
            }
        }
    }
}