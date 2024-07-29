using System;
using System.Threading;
namespace EventsAndDelegates
{
    public delegate void Notify(string message);
    public class Publisher
    {
        public event Notify OnNotify;

        public void DoWork()
        {
            // Simulate work
            Console.WriteLine("Doing work...");
            Thread.Sleep(3000);
            // Raise the event
            OnNotify?.Invoke("Work completed");
        }
    }

}
