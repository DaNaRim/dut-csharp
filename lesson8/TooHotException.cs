using System;

namespace ConsoleApp1.lesson8 {
    public class TooHotException : Exception {
        public TooHotException(string? message) : base(message) {
        }
    }
}