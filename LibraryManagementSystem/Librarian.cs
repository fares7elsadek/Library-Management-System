using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Librarian: User
    {


        private readonly int EmployeeNumber;

        public Librarian(string Name,int EmployeeNumber) : base(Name)
        {
            this.EmployeeNumber = EmployeeNumber;
        }

        public void AddBook(Library library,Book book)
        {
            library?.Add(book);
        }
        public void RemoveBook(Library library,Book book)
        {
            library?.Remove(book);
        }
    }
}
