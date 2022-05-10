using System;

namespace ConsoleApp1.lesson08 {
    public class TooHotException : Exception {
        public TooHotException(string? message) : base(message) {
        }
    }
}