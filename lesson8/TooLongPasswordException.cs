using System;

namespace ConsoleApp1.lesson8 {
    public class TooLongPasswordException : Exception {
        public TooLongPasswordException(string? message) : base(message) {
        }
    }
}