using System;
using System.Collections.Generic;

namespace ConvertAll
{
    class Program
    {
        // Function for converting one item into an Interval object
        public static Interval TimeWindowToInterval(TimeWindow timeWindow)
        {
            return new Interval(){Start = timeWindow.From, End = timeWindow.To};
        }

        // Fordefined Property
        static Interval[] openingIntervals {get;set;}

        // Selfdefined List to convert
        static List<TimeWindow> timeWindows = new List<TimeWindow>();

        static void Main(string[] args)
        {
            // Add Time Windows
            timeWindows.Add(new TimeWindow(){From = DateTime.Now ,To = (DateTime)DateTime.Now.AddHours(2)});

            // Convert All
            openingIntervals = timeWindows.ConvertAll(new Converter<TimeWindow, Interval>(TimeWindowToInterval)).ToArray();

            // Check Output
            foreach(var item in openingIntervals)
                Console.WriteLine("Opening: "+item.Start + ", Closing: " + item.End);
        }
    }
    // Fordefined Class
    class Interval
    {
        public DateTime Start {get;set;}
        public DateTime End {get;set;}
    }

    // Selfdefinded Class
    class TimeWindow
    {
        public DateTime From {get;set;}
        public DateTime To {get;set;}
    }
}
