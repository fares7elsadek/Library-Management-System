using LibraryManagementSystem;
using System;

namespace LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t\t Welcome to Library Management System\n\n\n");
            Library library = new Library();
            char choiceC='y';

            do
            {
                Console.Write("\t Are you a Regular User or Librarian (U,L)?  : ");
                char userType = char.ToUpper(Console.ReadLine()[0]);

                switch (userType)
                {
                    case 'L':
                        RunLibrarianInterface(library);
                        break;
                    case 'U':
                        RunUserInterface(library);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        continue;
                }

                Console.Write("Want to Continue (y/n): ");
                choiceC = char.ToLower(Console.ReadLine()[0]);
            } while (choiceC == 'y');
        }

        static void RunLibrarianInterface(Library library)
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t Welcome to Library Management System (Librarian Interface)\n\n\n");

            Console.Write("Please Enter Your Name : ");
            string name = Console.ReadLine();
            Librarian librarian = new Librarian(name, 1);

            char choiceL='y';
            do
            {
                DisplayLibrarianMenu(librarian);
                Console.WriteLine("[1] Add New Book");
                Console.WriteLine("[2] Delete Book");
                Console.WriteLine("[3] Display All Books");
                Console.WriteLine("[4] Display Borrowed Books\n\n");
                Console.Write("Your Choice: ");
                if (!int.TryParse(Console.ReadLine(), out int selectedOption))
                {
                    Console.WriteLine("Invalid option. Please try again.");
                    continue;
                }

                switch (selectedOption)
                {
                    case 1:
                        librarian.AddBook(library, ReadBookDetails());
                        Console.WriteLine("\nBook Added Successfully");
                        break;
                    case 2:
                        librarian.RemoveBook(library, ReadBookDetails());
                        Console.WriteLine("\nBook Removed Successfully");
                        break;
                    case 3:
                        library.Display();
                        break;
                    case 4:
                        library.DisplayBorrowedBooks();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

                Console.Write("Want to Continue (y/n): ");
                choiceL = char.ToLower(Console.ReadLine()[0]);
            } while (choiceL == 'y');
        }

        static void RunUserInterface(Library library)
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t Welcome to Library Management System (User Interface)\n\n\n");
            Console.Write("Please Enter Your Name : ");
            string name = Console.ReadLine();
            LibraryUser User = new LibraryUser(name, new LibraryCard(1));

            char choiceL = 'y';
            do
            {
                DisplayLibrarianMenu(User);
                Console.WriteLine("[1] Display All Books");
                Console.WriteLine("[2] Borrow Book\n\n");

                Console.Write("Your Choice: ");
                if (!int.TryParse(Console.ReadLine(), out int selectedOption))
                {
                    Console.WriteLine("Invalid option. Please try again.");
                    continue;
                }

                switch (selectedOption)
                {
                    case 1:
                        library.Display();
                        break;
                    case 2:
                        User.BorrowBook(ReadBookDetails(),library);
                        Console.WriteLine("Done");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

                Console.Write("Want to Continue (y/n): ");
                choiceL = char.ToLower(Console.ReadLine()[0]);
            } while (choiceL == 'y');
        }

        static void DisplayLibrarianMenu<T>(T user)
        {
            Console.Clear();
            Console.WriteLine($"\t\t\t\t Welcome to Library Management System\n\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        static Book ReadBookDetails()
        {
            Console.Write("\nBook Title: ");
            string title = Console.ReadLine();
            Console.Write("\nBook Author: ");
            string author = Console.ReadLine();
            Console.Write("\nBook Year: ");
            int year = int.Parse(Console.ReadLine());
            return new Book(title, author, year);
        }
    }
}
