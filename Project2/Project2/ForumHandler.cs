using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class ForumHandler
    {

	private Storage storage;

	public ForumHandler(){
	}	

        public static void addForum(String forumName, Administrator admin) {
            Storage.forumStorage.Add(new Forum(forumName, admin));
        }

        public static void addSubForum(Forum forum, String subForumName)
        {
            forum.addSubForum(new SubForum(subForumName));
        }

        public static void addDiscussion(SubForum subForum, String title, String content, ForumMember forumMember)
        {
            subForum.addDiscussion(new Discussion(title, new NewMessage(title, content, forumMember)));
        }
         
        public static void addReply(Message message, SubForum subForum, String content, ForumMember messageOwner)
        {
            message.addReply(new ReplyMessage(message.getTitle(), content, messageOwner));
        }

	    public static void printForums()
	    {
		    for (int i = 0; i < Storage.forumStorage.Count; i++)
		    {
		    	Console.WriteLine("Forum " + i + " : " + Storage.forumStorage.ElementAt(i).getName());
		    }
	}
    }
}
