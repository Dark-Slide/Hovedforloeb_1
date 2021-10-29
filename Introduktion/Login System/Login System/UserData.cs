using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_System
{
    public class UserData
    {
        internal class User
        { 
            private string Username { get; set; } // Username
            private int Id { get; set; } // User ID


            // UserData - Username, ID
            private List<User> UserInfo(List<User> users) 

            {
                User user1 = new User() { Username = "admin", Id = 0}; users.Add(user1);
                User user2 = new User() { Username = "Erik",  Id = 1}; users.Add(user2);
                User user3 = new User() { Username = "Klaus", Id = 2}; users.Add(user3);
                User user4 = new User() { Username = "Poul", Id = 3}; users.Add(user4);

                return users;

            }

            // Username Matcher - Return ID if the username Matches

            public int UsernameMatch(string InputUsername) 
            {
                List<User> users = new List<User>();
                foreach (var user in users)
                {
                    if (user.Username == InputUsername)
                    {
                        return user.Id;
                    }
                }
                return 404;
            }
        }
        internal class Password 
        { 
        private string password { get; set; }

            // PROTECTED PRIVATE Password Data




            // PROTECTED PRIVATE Password Matcher

        }
    }
}
