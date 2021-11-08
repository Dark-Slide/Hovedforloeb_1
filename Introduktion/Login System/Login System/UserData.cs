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
            private int Id { get; set; } // User ID
            private string Username { get; set; } // Username

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

            public static int UsernameMatch(string InputUsername) 
            {
                List<User> users = new List<User>();
                foreach (var user in users)
                {
                    if (user.Username.ToString() == InputUsername)
                    {
                        return user.Id;
                    }
                }
                return 404;
            }
        }
        internal class Password 
        {
            private int Id { get; set; } // User ID
            private string password { get; set; } // User Pass

            // PROTECTED PRIVATE Password Data

            protected List<Password> UserPass(List<Password> usersP)

            {
                Password erfsawwi = new Password() { password = "password", Id = 0 }; usersP.Add(erfsawwi);
                Password erfzwda = new Password() { password = "rgfiAW123", Id = 1 }; usersP.Add(erfzwda);
                Password awwdfrg = new Password() { password = "dfefopp!", Id = 2 }; usersP.Add(awwdfrg);
                Password sfoiesnf = new Password() { password = "efefkeowld,,,", Id = 3 }; usersP.Add(sfoiesnf);

                return usersP;

            }

            // PROTECTED PRIVATE Password Matcher

            public static bool PassMatch(string InputPassword)
            {
                List<Password> usersP = new List<Password>();
                foreach (var user in usersP)
                {
                    if (user.password == InputPassword)
                    {
                        return true;
                    }
                }
                return false; ;
            }
        }
    }
}
