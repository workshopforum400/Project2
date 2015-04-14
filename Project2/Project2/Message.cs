using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public abstract class Message
    {
       protected String title;
       protected String content;
       ForumMember owner;

        public Message(String title, String content, ForumMember messageOwner)
       {
           this.title = title;
           this.content = content;
           this.owner = messageOwner;
       }

       public abstract void addReply(ReplyMessage newReply);
       
        public virtual String getTitle()
       {
           return this.title;
       }
        

    }
}
