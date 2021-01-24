using System;
using System.Collections.Generic;
using System.Text;
using LLBZ.KnowledgeBase.Core.Security;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LLBZ.KnowledgeBase.Core.Test
{
    [TestClass]
    class UserTests
    {
        private User user;

        [TestInitialize]
        private void Initialize()
        {
            user = new User("Leo", "leo@gmail.com", "leo.b", "password");
        }

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
            Post p = new QuestionPost {
                Author = user,
                Subject = "How do I solve this?",
                Body = "The question's details.",
                CreationDate = DateTime.Now
            };

            user.PostQuestion(p);
        }

        [TestMethod]
        public void TestPermissions()
        {
            var permissionCategoryPost = new PermissionCategory("Post");
            var permissionCategoryBlock = new PermissionCategory("Block");

            var p1 = new Permission("Read answers", permissionCategoryPost) { Allow = false };
            var p2 = new Permission("Post answers", permissionCategoryPost) { Allow = false };
            var p3 = new Permission("Block Users", permissionCategoryBlock) { Allow = false };

            var role1 = new Role("Admin");
            var role2 = new Role("Contributor");


            var r1p1 = (Permission)p1.Clone();
            r1p1.Allow = true;
            var r1p2 = (Permission)p1.Clone();
            r1p2.Allow = true;
            var r1p3 = (Permission)p1.Clone();
            r1p3.Allow = true;
            role1.Permissions.Add(r1p1);
            role1.Permissions.Add(r1p2);
            role1.Permissions.Add(r1p3);

            var r2p1 = (Permission)p1.Clone();
            r2p1.Allow = true;
            var r2p2 = (Permission)p1.Clone();
            r2p2.Allow = true;
            var r2p3 = (Permission)p1.Clone();
            r2p3.Allow = false;
            role1.Permissions.Add(r2p1);
            role1.Permissions.Add(r2p2);
            role1.Permissions.Add(r2p3);

            user.Roles.Add(role1);
        }
    }
}
