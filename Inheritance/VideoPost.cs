using System;using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Inheritance
{
    class VideoPost:Post
    {
        //member fields
        protected int currentTime = 0;
        protected bool isPlaying = false;
        Timer timer;

        //Properties
        protected string videoURL { get; set; }
        protected int videoLength { get; set; }

        public VideoPost() { }

        public VideoPost(string title, string sendByUserName, string videoURL, int VideoLength,bool isPublic)
        {
            //Inherited
            this.ID = getNextID();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;
            //Specific
            this.videoURL = videoURL;
            this.videoLength = VideoLength;
        }
        //Edited the same method defined in Post.cs so that a link can be shown using the .ToString function as shown. 
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}. URL: {3}........ time remaining: {4}", this.ID, this.Title, this.SendByUserName, this.videoURL, this.videoLength);
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing...");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
            
        }

        private void TimerCallback(Object o)
        {
            if (isPlaying && currentTime < videoLength)
            {
                currentTime++;
                Console.WriteLine("Video at {0}s", currentTime);
                GC.Collect();//Garbage collection to clean up any mess. 
            }
        }

        public void Stop()
        {
            if (isPlaying && currentTime >= videoLength)
            {
                Console.WriteLine("Stopped... at {0}s", currentTime);
                currentTime = 0;
                timer.Dispose();//Cleans up and resets the timer being used. 
            }
        }

    }
}
