using FB.GAP.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatiN.Core;

namespace FB.GAP.Library
{
    public class FacebookLoginPage : IE
    {
        //email
        //pass
        //loginbutton


        private const string _uri = "https://www.facebook.com/login/";

        public FacebookLoginPage()
            : base(_uri)
        {
        }

        // Elements of the page
        public TextField UserNameTextField
        {
            get
            {
                return this.TextField(Find.ById("email"));
            }
        }

        public TextField PasswordTextField
        {
            get
            {
                return this.TextField(Find.ById("pass"));
            }
        }

        public Button LogOnButton
        {
            get
            {
                return this.Button(Find.ById("loginbutton"));
            }
        }

        // Action of the page
        public void LogOn(string userName, string password)
        {
            this.UserNameTextField.TypeText(userName);
            this.PasswordTextField.TypeText(password);
            this.LogOnButton.Click();
        }
    }
}
