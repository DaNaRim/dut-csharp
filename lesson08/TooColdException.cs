using System;

namespace ConsoleApp1.lesson08 {
    public class TooColdException : Exception {
        public TooColdException(string? message) : base(message) {
        }
    }
}