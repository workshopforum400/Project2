using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project2;

namespace Bridges
{
    public class RealBridge : Bridge
    {
        public RealBridge()
        { }

        public void addForum(String forumName, Administrator admin)
        {
            ForumHandler.addForum(forumName, admin);
        }

        void addSubForum(Forum forum, String subForumName)
        {
            ForumHandler.addSubForum(forum, subForumName);
        }

        void addDiscussion(SubForum subForum, String title, String content, ForumMember forumMember)
        {
            ForumHandler.addDiscussion(subForum, title, content, forumMember);
        }
        void addReply(Message message, SubForum subForum, String content, ForumMember messageOwner)
        {
            ForumHandler.addReply(message, subForum, content, messageOwner);
        }
    }
}
