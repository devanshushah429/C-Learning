using System;

namespace EventsAndDelegates
{
    public class GiftHandler
    {
        public void OpenGift(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Open Present");
        }
        public void TakePicture(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Took Picture");
        }
    }
}