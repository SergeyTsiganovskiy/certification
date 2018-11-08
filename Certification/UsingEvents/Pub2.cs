using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingEvents
{
    public class Pub2
    {
        public event EventHandler<MyArgs> OnChange = delegate { };
        public event EventHandler OnChangeEmpty = delegate { };
        public void Raise()
        {
            MyArgs myArgs = new MyArgs(42);
            myArgs.Value = 10;
            OnChange(this, myArgs);
            OnChangeEmpty(this, EventArgs.Empty);
        }
    }

    public class MyArgs : EventArgs
    {
        public MyArgs(int value)
        {
            Value = value;
        }
        public int Value { get; set; }
    }
}
