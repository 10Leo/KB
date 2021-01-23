using System;
using System.Collections.Generic;
using System.Text;

namespace LLBZ.KnowledgeBase.Core
{
    public class Metrics
    {
        public IList<User> Upvotes { get; set; }
        public IList<User> Downvotes { get; set; }
    }
}
