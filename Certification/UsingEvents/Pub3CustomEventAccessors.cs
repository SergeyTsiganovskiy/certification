using System;

namespace UsingEvents
{
    public class Pub3CustomEventAccessors
    {
        private event EventHandler<MyArgs> onChange = delegate { };
        public event EventHandler<MyArgs> OnChange
        {
            add
            { // t’s important to put a lock around adding and removing
              // subscribers to make sure that the operation is thread safe.
                lock (onChange)
                {
                    onChange += value;
                }
            }
            remove
            {
                lock (onChange)
                {
                    onChange -= value;
                }
            }
        }
        public void Raise()
        {
            onChange(this, new MyArgs(42));
        }
    }
}

// events are not delegates; instead they are a convenient wrapper around delegates.
