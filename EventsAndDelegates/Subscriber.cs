using System;

namespace EventsAndDelegates
{
    public class Subscriber
    {
        public void Subscribe(Publisher publisher)
        {
            publisher.OnNotify += HandleNotification;


            // cant do  because not same patameter as in delegate
            // publisher.OnNotify += HandleNotification2;
        }

        public void HandleNotification2(int message)
        {

        }
        private void HandleNotification(string message)
        {
            Console.WriteLine("Received notification: " + message);
        }
    }

}
