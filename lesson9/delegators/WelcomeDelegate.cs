namespace ConsoleApp1.lesson9.delegators {

    public class WelcomeDelegate {

        public delegate void SayHelloDel();

        public static SayHelloDel sayHelloDel = Welcome.SayHello;

    }

}