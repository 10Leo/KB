using System;
using System.Collections.Generic;
using System.Text;

namespace LLBZ.KnowledgeBase.Core
{
    public class QuestionPost : Post
    {
        public string Subject { get; set; }

        //TODO: consider if this is really necessary from a DDD point of view
        public IEnumerable<AnswerPost> Answers { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
    }
}
