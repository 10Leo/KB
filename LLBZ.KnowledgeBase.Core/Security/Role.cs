using System;
using System.Collections.Generic;
using System.Text;

namespace LLBZ.KnowledgeBase.Core.Security
{
    public class Role
    {
        public string Name { get; set; }

        public ISet<Permission> Permissions { get; set; } = new HashSet<Permission>();

        public Role(string name)
        {
            this.Name = name;
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
            return obj != null && obj is Role && (obj as Role).Name == this.Name;
        }

        #endregion Hash
    }
}
