using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
   public class Forum
    {
       private List<SubForum> subForums;
       private Administrator admin;
       private String forumName;

       public Forum(String forumName, Administrator admin) {
           this.admin = admin;
           this.forumName = forumName;
            this.subForums=new List<SubForum>();
       }

        public void addSubForum(SubForum subForum)
       {
           this.subForums.Add(subForum);
       }

       public String getName()
       {
           return this.forumName;
       }

    }
}
