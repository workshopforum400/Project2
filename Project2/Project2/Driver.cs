using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
   public class Driver
    {
        public static void Main(String[] args)
        {
        	ForumHandler fHandler = new ForumHandler();
		    Administrator fAdmin1 = new Administrator("bla");
		    Administrator fAdmin2 = new Administrator("ya");
		    Administrator fAdmin3 = new Administrator("blabla");
		    fHandler.addForum("forum 1", fAdmin1);
		    fHandler.addForum("forum 2", fAdmin2);
		    fHandler.addForum("forum 3", fAdmin3);
            fHandler.printForums();
            System.Threading.Thread.Sleep(10000);
        }
    }
}
