using Facebook;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingFbApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var userId = "100011395338319";
            var fb = new FacebookClient();
            /*
            dynamic result = fb.Get("oauth/access_token", new
            {
                client_id = "244874662521335",
                client_secret = "4a974bab1ed4bbb794ea99bc2612d52a",
                grant_type = "client_credentials",
                scope = "publish_stream,publish_actions"
            });
            */
            fb.AppId = "244874662521335";
            fb.AppSecret = "4a974bab1ed4bbb794ea99bc2612d52a";


            var userAccesstoken = "EAADetlNGKfcBAIR3pOA8npgu2ELBVwnXrKsQuZBvxUuuYvVZCOrercv01UNxsUfSZBLD1WQkc65eXZAjL8P0qCuJ8PocdT4ZAjP1btyLR7sHQncTvCWT9xEg1ODPXV2guVZAQdVF2RqTBWNj2kO2cCiKHv6VMkRwXZBOGrWrER0vMZA8AjmIKjqE6ZBkdZCQXr1fgZD";

            fb.AccessToken = userAccesstoken;//result.access_token;

            dynamic parameters = new ExpandoObject();
            parameters.message = "test message";

            var x = fb.Post("me/feed", parameters);
        }
    }
}
