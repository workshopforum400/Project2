using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project2;

namespace Bridges
{
    public class ProxyBridge : Bridge
    {
        private Bridge real;

        public ProxyBridge() { }

        public void setRealBridge(Bridge real)
        {
            this.real = real;
        }

        public void addForum(String forumName, Administrator admin)
        {
            if (this.real != null)
                real.addForum(forumName, admin);
        }

        void addSubForum(Forum forum, String subForumName)
        {
            if (this.real != null)
                real.addSubForum(forum, subForumName);
        }

        void addDiscussion(SubForum subForum, String title, String content, ForumMember forumMember)
        {
            if (this.real != null)
                real.addDiscussion(subForum, title, content, forumMember);
        }

        void addReply(Message message, SubForum subForum, String content, ForumMember messageOwner)
        {
            if (this.real != null)
                real.addReply(message, subForum, content, messageOwner);
        }
    }
}
