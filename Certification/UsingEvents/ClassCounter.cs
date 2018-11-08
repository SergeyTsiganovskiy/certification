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

//For naming convention, it is good to prefix a method’s name with On only when it is
//going to be used with event, for example, OnAlert.

//Event shall always be invoked inside a class where it is defined.Unlike delegates,
//events cannot be invoked outsite the class where they are defined.