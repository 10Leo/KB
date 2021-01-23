using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LLBZ.KnowledgeBase.Core.Test
{
    [TestClass]
    class UserTests
    {
        [TestMethod]
        public void TestUserCreation()
        {
        }

        [TestMethod]
        public void TestUserDeletion()
        {
        }

        [TestMethod]
        public void TestUserPost()
        {
            User u = new User();

            Post p = new QuestionPost {
                Author = u,
                Subject = "How do I solve this?",
                Body = "The question's details.",
                CreationDate = DateTime.Now
            };

            u.PostQuestion(p);
        }
    }
}
