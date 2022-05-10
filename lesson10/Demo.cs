using System;

namespace ConsoleApp1.lesson10 {

    public class Demo {

        public static void Main() {
            User user1 = new ("Tom", 2000, "aezakmi", "superPassword");
            User user2 = new ("Jerry", 2010, "dut@g.com", "123");
            
            user1.ageListener += DisplayAge;
            user2.loginListener += IsUserConfirmed;
            
            user1.GetAge();
            user1.SetYearOfBirth(1000);
            
            user2.Login();
            
            void DisplayAge(string message, int age) {
                Console.WriteLine(message + " user age = " + age);
            }

            void IsUserConfirmed(string message) {
                Console.WriteLine(message);
            }
        }
        
    }

}