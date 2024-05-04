using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal abstract class User
    {
        public readonly string Name;

        public User(string Name)
        {
            this.Name = Name;
        }
    }
}
