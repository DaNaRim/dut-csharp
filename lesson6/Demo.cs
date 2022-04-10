namespace ConsoleApp1.lesson6 {
    public class Demo {
        public static void Main() {
            Classmates classmates = new("Name", 18, "Namana");
            Classmates classmates2 = new("Name2", 0, "Baldezh");
            classmates.printName();
            classmates.printNameAndAge();
            classmates2.printNameAndStatus();

            Hobbies hobbies = new(HobbiesName.RUNNING, 100, 10);
            Hobbies hobbies2 = new(HobbiesName.YOGA, 10, 2);
            hobbies.printName();
            hobbies.printNameAndPopularityRating();
            hobbies2.printNameAndYearsOfExperience();
        }
    }
}