using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Inheritance
{
    class Post//For example -> Social media post, etc. 
    {
        private static int currentPostID;


        //properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUserName { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUserName = "Sean Mongru";
        }
        //Instance constructor
        public Post(string title, bool isPublic, string sendByUserName)
        {
            this.ID = 0;
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUserName = sendByUserName;
        }
        //increment and return currentPostID
        protected int getNextID()
        {
            return ++currentPostID;
        }
        //We want to be able to edit our posts as well as define it's publicity:
        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }
        //Virtual Method of the ToString Method that is inherited from method
        //from System.Object
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUserName);
        }
    }
}
