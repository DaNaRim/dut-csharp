using System;

namespace ConsoleApp1.lesson03.homework {
    public class Project {
        private string name;
        private int daysInWork;
        private int mark;
        private bool isFinished;

        public Project(string name, int daysInWork, int mark, bool isFinished) {
            this.name = name;
            this.daysInWork = daysInWork;
            this.mark = mark;
            this.isFinished = isFinished;
        }

        public void WriteNameAndMark() {
            Console.WriteLine($"{nameof(name)}: {name}, {nameof(mark)}: {mark}");
        }

        public void WriteNameAndStatus() {
            Console.WriteLine($"{nameof(name)}: {name}, {nameof(isFinished)}: {isFinished}");
        }
    }
}