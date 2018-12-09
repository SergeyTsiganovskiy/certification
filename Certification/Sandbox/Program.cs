using System;
using System.IO;
using System.Text;
using UnderstandingDelegates;

namespace Sandbox
{
    public class Program
    {
        public static void Main(string[] args)
        {

            #region Understanding delegates
            //// v1 - Practice.DelegateName del = new Practice.DelegateName(display);

            //DelegateName del = DelegateTest.Display;
            //del("Test message");

            //// the same as previous
            //del.Invoke("New test message");

            //// multicast delegate

            //MulticastDelegateName ndel = MulticastDelagateTest.Display;

            //ndel += MulticastDelagateTest.Show;
            //ndel += MulticastDelagateTest.Screen;

            //ndel("Message");

            //ndel -= MulticastDelagateTest.Show;

            //ndel("New message");

            //// iterate all references

            //foreach (MulticastDelegateName item in ndel.GetInvocationList())
            //{
            //    item("foreach");
            //}

            //Counter(1, 2, DelegateEventsDemo.GetFeedBackDelegate());
            //Console.ReadLine();

            #endregion


            #region Using lambda

            //TestLambda(() => Console.WriteLine("Inside Lambda"));

            #endregion


            #region Using events

            //порядок создания события.
            //1.Определите условие возникновения события и методы которые должны сработать.
            //2.Определите сигнатуру этих методов и создайте делегат на основе этой сигнатуры.
            //3.Создайте общедоступное событие на основе этого делегата и вызовите, когда условие сработает.
            //4.Обязательно(где - угодно) подпишитесь на это событие теми методами, которые должны сработать и сигнатуры которых подходят к делегату.

            //    Класс, в котором вы создаете событие(генерируете) называется классом-издателем, а классы, чьи методы подписываются на это событие при помощи "+=" — классами - подписчиками.

            //ClassCounter Counter = new ClassCounter();
            //Handler_I Handler1 = new Handler_I();
            //Handler_II Handler2 = new Handler_II();

            //Counter.OnCount += Handler1.Message;
            //Counter.OnCount += Handler2.Message;

            //Counter.Count();

            //Pub pub =new Pub();
            //pub.OnChange += () => Console.WriteLine("Message event outside");
            //pub.Raise();

            //Pub2 pub2 = new Pub2();
            //pub2.OnChange += (sender, e) => Console.WriteLine("Event raised: {0}", e.Value);
            ////pub2.OnChangeEmpty += (sender, null) => Console.WriteLine("Event raised: {0}");

            //pub2.Raise();

            //Pub4InvocationList pub4 = new Pub4InvocationList();
            //pub4.OnChange += (sender, e) => Console.WriteLine("Subscriber 1 called");
            //pub4.OnChange += (sender, e) => { throw new Exception(); };
            //pub4.OnChange += (sender, e) => Console.WriteLine("Subscriber 3 called");
            //try
            //{
            //    pub4.Raise();
            //}
            //catch (AggregateException ex)
            //{
            //    Console.WriteLine(ex.InnerExceptions.Count);
            //}

            //EventProgram obj1 = new EventProgram();
            //string result = obj1.WelcomeUser("Tutorials Point");
            //Console.WriteLine(result);
            //Console.ReadKey();

            //Person person = new Person("Ann");
            //person.IsChanged += n => n.Equals(person.Name);
            //person.Name = "Ann";
            //Console.ReadKey();
            #endregion

            #region Performe IO operations

            string temp = Path.GetRandomFileName();

            string path = @"c:\temp\test.dat";
            using (FileStream fileStream = File.Create(path))
            {
                string myValue = "MyValue";
                byte[] data = Encoding.UTF8.GetBytes(myValue);
                fileStream.Write(data, 0, data.Length);
            }


            string path1 = @"c:\temp\test.dat";
            using (StreamWriter streamWriter = File.CreateText(path1))
            {
                string myValue = "MyValue";
                streamWriter.Write(myValue);
            }


            using (FileStream fileStream = File.OpenRead(path))
            {
                byte[] data = new byte[fileStream.Length];
                for (int index = 0; index < fileStream.Length; index++)
                {
                    data[index] = (byte)fileStream.ReadByte();
                }
                Console.WriteLine(Encoding.UTF8.GetString(data)); // Displays: MyValue
            }

            using (FileStream fileStream = File.Create(path))
            {
                using (BufferedStream bufferedStream = new BufferedStream(fileStream))
                {
                    using (StreamWriter streamWriter = new StreamWriter(bufferedStream))
                    {
                        streamWriter.WriteLine(path);
                    }
                }
            }

            #endregion

        }

        static void TestLambda(Action act)
        {
            Console.WriteLine("Test Lambda Method");
            act();
        }

        private static void Counter(int p1, int p2, FeedBack feedBack)
        {
            for (int i = p1; i <= p2; i++)
            {
                if (feedBack != null)
                {
                    feedBack(i);
                }
            }
        }
    }
}
