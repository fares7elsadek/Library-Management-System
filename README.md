# Library Management System

This is a simple Library Management System implemented in C# using Object-Oriented Programming principles.

## UML Diagram

![Library Management System UML Diagram](https://github.com/fares7elsadek/Library-Management-System/blob/main/uml/libraryManagementUML.png)

## Classes and Descriptions

### Library

The `Library` class represents the library entity in the system. It manages the collection of books and provides functionalities to add, remove, and display books.

- **Methods**:
  - `Add(Book book)`: Adds a book to the library.
  - `Remove(Book book)`: Removes a book from the library.
  - `Display()`: Displays the list of books in the library.
  - `BorrowBook(Book book)`: Marks a book as borrowed.

### Book

The `Book` class represents a book entity with properties such as title, author, and publication year.

- **Properties**:
  - `Title`: The title of the book.
  - `Author`: The author of the book.
  - `Year`: The publication year of the book.

- **Methods**:
  - `Equals(object? obj)`: Overrides the equality comparison method.
  - `GetHashCode()`: Generates a hash code for the book.
  - `ToString()`: Converts the book object to a string representation.

### Librarian

The `Librarian` class represents a librarian who manages the library operations.

- **Properties**:
  - `EmployeeNumber`: The unique employee number of the librarian.

- **Methods**:
  - `AddBook(Library library, Book book)`: Adds a book to the library.
  - `RemoveBook(Library library, Book book)`: Removes a book from the library.

### LibraryCard

The `LibraryCard` class represents a library card issued to library users.

- **Properties**:
  - `Card`: The unique identifier of the library card.

### User

The `User` class represents a generic user in the library system.

- **Properties**:
  - `Name`: The name of the user.

### LibraryUser

The `LibraryUser` class represents a library user who can borrow books from the library.

- **Properties**:
  - `Card`: The library card associated with the user.

- **Methods**:
  - `BorrowBook(Book book, Library library)`: Allows the user to borrow a book from the library.

## Usage

Provide instructions on how to use your library management system here.

## Contributing

If you'd like to contribute to this project, feel free to submit a pull request.

## License

This project is licensed under the [MIT License](link_to_license_file).
