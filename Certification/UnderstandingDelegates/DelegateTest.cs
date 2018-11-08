using System;

namespace UnderstandingDelegates
{
    public delegate void DelegateName(string msg);

    public class DelegateTest
    {
        public static void Display(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    public delegate void FeedBack(Int32 val);

    public class DelegateEventsDemo
    {
        private static void FeedBackToConsole(Int32 val)
        {
            Console.WriteLine("Good morning delegates" + val);
        }

        public static FeedBack GetFeedBackDelegate()
        {
            return FeedBackToConsole;
        }
    }
}
