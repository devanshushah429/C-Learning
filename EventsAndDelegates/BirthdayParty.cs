using System;

namespace EventsAndDelegates
{

    public partial class Program
    {
        public class BirthdayGift
        {
            public delegate void AddGiftHandler(String message);
            public event AddGiftHandler Notify;
            public void AddGift()
            {
                // add gift logic

                // call the OnNotify Method
                OnNotify();
            }
            public void OnNotify()
            {
                // Invoke the notify method
                Notify("Added gift successfully");
            }
        }

    }
}
