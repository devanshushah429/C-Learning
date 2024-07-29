using System;

namespace EventsAndDelegates
{

    public partial class Program
    {
        public static void Main()
        {
            BirthdayPartyProblem();
            Console.Read();
        }
        #region Birthday Party Problem
        public static void BirthdayPartyProblem()
        {
            BirthdayGift b1 = new BirthdayGift();
            GiftHandler g = new GiftHandler();
            b1.Notify += g.OpenGift;
            b1.AddGift();
            BirthdayGift b2 = new BirthdayGift();
            b2.Notify += g.OpenGift;
            b2.AddGift();
            BirthdayGift b3 = new BirthdayGift();
            b3.Notify += g.TakePicture;
            b3.AddGift();
        }
        #endregion


        #region Video Encoder Problem
        public static void VideoEncoderProblem()
        {
            VideoEncoder encoder = new VideoEncoder();
            MailService mail = new MailService();
            encoder.OnVideoEncoded += mail.DoMail;

            // Now if we want to add the message service just we need to do is subscribe to message service
            MessageService ms = new MessageService();
            encoder.OnVideoEncoded += ms.DoMessage;

            // now call the encode method
            encoder.EncodeVideo();
        }
        #endregion  

        #region PublisherSubscriverProblem
        private static void PublisherSubscriverProblem()
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            // Subscriber subscribes to the publisher's event
            subscriber.Subscribe(publisher);

            // Trigger the event
            publisher.DoWork();
        }
        #endregion

    }
}
