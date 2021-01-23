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

        public void PostQuestion(Post p)
        {
            Posts.ToList().Add(p);
        }
    }
}
