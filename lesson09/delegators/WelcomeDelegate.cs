namespace ConsoleApp1.lesson09.delegators {

    public class WelcomeDelegate {

        public delegate void SayHelloDel();

        public static SayHelloDel sayHelloDel = Welcome.SayHello;

    }

}