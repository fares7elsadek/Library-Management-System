using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Book
    {
        private readonly string Title;
        private readonly string Author;
        private readonly int Year;

        public Book(string Title,string Author,int Year)
        {
            this.Title = Title;
            this.Author = Author;   
            this.Year = Year;  
        }

        public static bool operator ==(Book left, Book right) => left.Equals(right);
        public static bool operator !=(Book left, Book right) => !left.Equals(right);
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != typeof(Book))
                throw new Exception("Not Book type");
            Book book = (Book)obj;
            return this.Year == book.Year
                   && this.Title == book.Title
                   && this.Author == book.Author;
        }
        public override int GetHashCode()
        {
            int num = 7;
            num = num * 31 + this.Year.GetHashCode();
            num = num * 31 + this.Author.GetHashCode();
            num = num * 31 + this.Title.GetHashCode();
            return num;
        }
        public override string ToString()
        {
            return $"\t\t||{this.Title}\t\t{this.Author}\t\t\t{this.Year}||\n\n";
        }
    }
}
