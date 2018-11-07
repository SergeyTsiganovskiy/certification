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
}
