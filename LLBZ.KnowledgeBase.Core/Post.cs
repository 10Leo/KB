using System;
using System.Collections.Generic;
using System.Text;

namespace LLBZ.KnowledgeBase.Core
{
    public abstract class Post
    {
        public string Body { get; set; }

        public User Author { get; set; }
        //public IEnumerable<User> Contributors { get; set; }

        public Metrics Metrics { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}
