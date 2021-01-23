using System;
using System.Collections.Generic;
using System.Text;

namespace LLBZ.KnowledgeBase.Core
{
    public class AnswerPost : Post
    {
        public Post ParentQuestion { get; set; }

        public bool IsMarkedAsAnswer { get; set; }
    }
}
