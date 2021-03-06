using System;

namespace ConsoleApp1.lesson04.homework {
    public class Demo {
        // public static void Main(string[] args) {
        //     CompEx();
        //     boardEx();
        // }

        static void CompEx() {
            Component component = new Component(
                Console.ReadLine(),
                Console.ReadLine(),
                Int32.Parse(Console.ReadLine()));
            component.PrintAllFields();
            component.PrintNameAndCountPins();
        }

        static void boardEx() {
            string boardNameStr = Console.ReadLine();
            BoardName boardName;
            switch (boardNameStr) {
                case "GIANT_BOARD":
                    boardName = BoardName.GIANT_BOARD;
                    break;
                case "OSD32MP1_BRK_FLEXIBLE_PROTOTYPING_PLATFORM":
                    boardName = BoardName.OSD32MP1_BRK_FLEXIBLE_PROTOTYPING_PLATFORM;
                    break;
                case "BEAGLEBONE_GREEN_GATEWAY":
                    boardName = BoardName.BEAGLEBONE_GREEN_GATEWAY;
                    break;
                case "ESP32_SE2_SAOLA_1":
                    boardName = BoardName.ESP32_SE2_SAOLA_1;
                    break;
                default:
                    boardName = BoardName.SIMPLELINK_WI_FI_CC3200_LAUNCHPAD;
                    break;
            }

            Board board = new Board(
                boardName,
                Int32.Parse(Console.ReadLine()),
                Int32.Parse(Console.ReadLine()));
            board.PrintNameAndCountPins();
            board.PrintNameAndRankingPlace();
        }

        /*
SomeName
test
9

GIANT_BOARD
11
98
*/
    }
}