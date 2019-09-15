using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ImagePost:Post//Inherits the attributes and methods from Post Class.  
    {
        public string ImageURL { set; get; }

        public ImagePost() { }

        public ImagePost(string title, string sendByUserName, string imageURL, bool isPublic)
        {
            //These 4 properties are inherited from Post
            this.ID = getNextID();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;
            //ImageURL is not inherited from Post, it is unique to this class -> ImagePost
            this.ImageURL = imageURL;
        }
        //Edited the same method defined in Post.cs so that a link can be shown using the .ToString function as shown. 
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}. URL: {3}", this.ID, this.Title, this.SendByUserName, this.ImageURL);
        }
    }
}
