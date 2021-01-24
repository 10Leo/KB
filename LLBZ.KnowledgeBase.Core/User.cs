using LLBZ.KnowledgeBase.Core.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LLBZ.KnowledgeBase.Core
{
    public class User
    {
        public string Name { get; set; }
        public Account Account { get; set; }

        public IEnumerable<Post> Posts { get; set; }
        public ISet<Role> Roles { get; } = new HashSet<Role>();

        public User(string name, string email, string username, string password)
        {
            this.Name = name;
            this.Account = new Account { Email = email, Username = username, Password = password };
        }

        public void PostQuestion(Post p)
        {
            Posts.ToList().Add(p);
        }
    }
}
