using FB.GAP.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTester
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            FacebookLoginPage login = new FacebookLoginPage();
            
            login.WaitForComplete();


                //xhpc_message

            login.LogOn("dudz.business@gmail.com", "2Winter*8");
                //hasText = somePage.ContainsText("Dixin");

            login.ClearCache();
            login.ClearCookies();
                

                //https://www.facebook.com/groups/1698197500455137/yourposts/

                 
                //TO COMMENT:
                //get permalink?????
                //comment id
                //add_comment_text
            } 
        }  
    }
}
