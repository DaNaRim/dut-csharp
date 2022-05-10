using System;

namespace ConsoleApp1.lesson10 {

    public class User {

        private string name;
        private int yearOfBirth;
        private string email;
        private string password;
        private bool status;

        public  delegate void AgeListener(string message, int age);

        public event AgeListener ageListener;

        public delegate void LoginListener(string message);

        public event LoginListener loginListener;

        public User(string name, int yearOfBirth, string email, string password) {
            this.name = name;
            this.yearOfBirth = yearOfBirth;
            this.email = email;
            this.password = password;
            status = false;
        }


        public int GetAge() {
            int age = DateTime.Now.Year - yearOfBirth;

            if (age < 18) ageListener?.Invoke("The user is a minor", age);
            if (age > 120) ageListener?.Invoke("User is a vampire", age);

            return age;
        }

        public void SetYearOfBirth(int yearOfBirth) {
            ageListener?.Invoke("User changed his age", DateTime.Now.Year - yearOfBirth);
            this.yearOfBirth = yearOfBirth;
        }

        public void Login() {
            if (email == "dut@g.com" && password == "123") {
                status = true;
                loginListener?.Invoke("User confirmed");
            } else if (email == "dut@g.com") {
                loginListener?.Invoke("Wrong password");
            } else {
                loginListener?.Invoke("Wrong username");
            }
        }

    }

}