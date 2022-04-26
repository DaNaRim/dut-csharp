using System;

namespace ConsoleApp1.lesson8 {
    public class TooColdException : Exception {
        public TooColdException(string? message) : base(message) {
        }
    }
}