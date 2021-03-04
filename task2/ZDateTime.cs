using System;

namespace task2
{
    public class ZDateTime
    {
        public DateTime CurrentTimeFormatOne { get; set; } = DateTime.Now;
        
        public DateTime CurrentTimeFormatTwo { get; set; } = DateTime.Now;

        public void ShowTime()
        {
            Console.WriteLine("First format: " + CurrentTimeFormatOne);
            
            Console.WriteLine("First format: " + CurrentTimeFormatTwo);
        }
    }
}