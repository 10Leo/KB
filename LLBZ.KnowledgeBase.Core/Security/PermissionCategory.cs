using System;
using System.Collections.Generic;
using System.Text;

namespace LLBZ.KnowledgeBase.Core.Security
{
    public class PermissionCategory
    {
        public PermissionCategory(string name)
        {
            this.Name = name;
        }

        public string Name { get; }
    }
}
