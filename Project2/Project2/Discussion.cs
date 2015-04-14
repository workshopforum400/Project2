using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
   public class Discussion
    {
        String title;
        Message firstMessage;

        public Discussion(String title, Message firstMessage)
        {
        	this.title = title;
        	this.firstMessage = firstMessage;
        }
    }
}
