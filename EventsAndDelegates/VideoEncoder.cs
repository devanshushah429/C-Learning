using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        public delegate void VideoEncodedEventHandler(String message);

        public event VideoEncodedEventHandler OnVideoEncoded;
        public void EncodeVideo()
        {
            Thread.Sleep(3000);

            OnVideoEncoded?.Invoke("Video Encoded Successfully");
        }
    }

}
