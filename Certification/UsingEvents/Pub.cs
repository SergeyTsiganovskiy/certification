using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingEvents
{
    public class Pub
    {
        public event Action OnChange = delegate { }; // empty delegate prevent checking event for null
        public void Raise()
        {
            OnChange();
        }
    }
}
