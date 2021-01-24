using System;
using System.Collections.Generic;
using System.Text;

namespace LLBZ.KnowledgeBase.Core.Security
{
    public class Permission : ICloneable
    {
        public PermissionCategory Category { get; }
        public string Name { get; }

        public bool Allow { get; set; } = false;

        public Permission(string name, PermissionCategory category)
        {
            this.Name = name;
            this.Category = category;
        }

        #region Hash

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 13;
                hash = (hash * 7) + Name.GetHashCode();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is Permission && (obj as Permission).Name == this.Name;
        }

        #endregion Hash

        public object Clone()
        {
            var p = new Permission(this.Name, this.Category) { Allow = this.Allow };
            return p;
        }
    }
}
