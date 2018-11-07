using System;

namespace UnderstandingDelegates
{
    public delegate void MulticastDelegateName(string msg);

    public class MulticastDelagateTest
    {
        public static void Display(string msg)
        {
            Console.WriteLine("display {0}", msg);
        }

        public static void Show(string msg)
        {
            Console.WriteLine("show {0}", msg);
        }

        public static void Screen(string msg)
        {
            Console.WriteLine("screen {0}", msg);
        }
    }
}
