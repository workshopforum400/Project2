using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class SubForum
    {
        private String name;
        private List<Moderator> moderators;
        private List<Discussion> discussions;
       
        public SubForum(String name)
        {
            this.name = name;
            this.moderators = new List<Moderator>();
            this.discussions = new List<Discussion>();
        }

        public void addDiscussion(Discussion newDiscussion)
        {
            this.discussions.Add(newDiscussion);
        }

        public String getName()
        {
            return this.name;
        }

    }
}
