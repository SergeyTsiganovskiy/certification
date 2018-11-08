using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingEvents
{
    public class ClassCounter
    {
        public delegate void MethodContainer();
        public event MethodContainer OnCount;

        public void Count()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 71)
                {
                    if (OnCount != null) // or OnCount?.Invoke(); if no subscribers avoid nullreferenceexception
                    {
                        OnCount();
                    }
                }
            }
        }
    }
}

// Publisher-subsriber approach is used to establish LOOSE COUPLING between components in an application.