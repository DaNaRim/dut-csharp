namespace ConsoleApp1.lesson9 {

    public class MyTextDelegate {

        public delegate void PrintTextTwiceDel(string text);
        public delegate char GetFirstSignDel(string text);

        public static PrintTextTwiceDel printTextTwiceDel = MyText.PrintTextTwice;
        public static GetFirstSignDel getFirstSignDel = MyText.GetFirstSign;

    }

}