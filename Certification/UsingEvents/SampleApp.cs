using System;

namespace UsingEvents
{
    public delegate string MyDel(string str);

    public class EventProgram
    {
        public event MyDel MyEvent;

        public EventProgram()
        {
            this.MyEvent += this.WelcomeUser;
        }

        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }
    }
}