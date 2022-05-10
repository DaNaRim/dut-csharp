using System;

namespace ConsoleApp1.lesson08 {
    public class TooLongPasswordException : Exception {
        public TooLongPasswordException(string? message) : base(message) {
        }
    }
}