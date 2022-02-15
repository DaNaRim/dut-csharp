namespace ConsoleApp1.lesson3 {
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

        public string WriteNameAndMark() {
            return $"{nameof(name)}: {name}, {nameof(mark)}: {mark}";
        }
        
        public string WriteNameAndStatus() {
            return $"{nameof(name)}: {name}, {nameof(isFinished)}: {isFinished}";
        }
    }
}