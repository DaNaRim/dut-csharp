using System;

namespace ConsoleApp1.lesson4.homework {
    public struct Board {
        private BoardName name;
        private int countPins;
        private int rankingPlace;

        public Board(BoardName name, int countPins, int rankingPlace) {
            this.name = name;
            this.countPins = countPins;
            this.rankingPlace = rankingPlace;
        }

        public void PrintNameAndRankingPlace() {
            Console.WriteLine($"{nameof(name)}: {name}, " +
                              $"{nameof(rankingPlace)}: {rankingPlace}");
        }

        public void PrintNameAndCountPins() {
            Console.WriteLine($"{nameof(name)}: {name}, " +
                              $"{nameof(countPins)}: {countPins}");
        }
    }
}