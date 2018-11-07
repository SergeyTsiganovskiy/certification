using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace UsingLambdaExpression
{
    public class LambdaTest
    {
        private Action note = () => Console.WriteLine();
        private Action<string> note_ = message => Console.WriteLine(message);
        
        // async lambdas
        // The number of times we have run DoSomethingAsync.
        private int Trials = 0;
        // Create an event handler for the button.
        private void Form1_Load(object sender, EventArgs e)
        {
            //runAsyncButton.Click += async (button, buttonArgs) =>
            //{
            //    int trial = ++Trials;
            //    statusLabel.Text = "Running trial " + trial.ToString() + "...";
            //    await DoSomethingAsync();
            //    statusLabel.Text = "Done with trial " + trial.ToString();
            //};
        }
        // Do something time consuming.
        async Task DoSomethingAsync()
        {
            // In this example, just waste some time.
            await Task.Delay(3000);
        }
    }
}
