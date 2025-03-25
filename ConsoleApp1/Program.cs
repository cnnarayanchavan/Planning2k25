using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("123-456", "C# Programming", "XYZ");
            book1.DisplayInfo();

            // Inheritance Example
            Student student = new Student(101, "Narayan", "S2025");
            Teacher teacher = new Teacher(201, "Dr.Suresh", "Computer Science");

            student.DisplayMemberInfo();
            teacher.DisplayMemberInfo();
            
            // Polymorphism Example
            Library library = new Library();
            library.SearchBook("C# Programming");
            library.SearchBook("Narayan", true);
            library.SearchBook(123456);

            FineCalculator studentFine = new StudentFine();
            FineCalculator teacherFine = new TeacherFine();

            studentFine.CalculateFine(5);
            teacherFine.CalculateFine(5);

            // Abstraction Example
            Librarian librarian = new Librarian();
            librarian.GetMembershipDetails();
            librarian.BorrowBook();
            librarian.ReturnBook();
        }
    }
}

//Encapsulation... 
class Book
{
    private string isbn;
    private string title;
    private string author;

    public string ISBN
    {
        get { return isbn; }
        private set { isbn = value; }  // Restricted access to modify
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public Book(string isbn, string title, string author)
    {
        this.isbn = isbn;
        this.title = title;
        this.author = author;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Book: {Title}, Author: {Author}, ISBN: {ISBN}");
    }
}

//Inheritance 
// Base Class
class LibraryMember
{
    public int MemberID { get; private set; }
    public string Name { get; set; }

    public LibraryMember(int memberId, string name)
    {
        MemberID = memberId;
        Name = name;
    }

    public virtual void DisplayMemberInfo()
    {
        Console.WriteLine($"Member ID: {MemberID}, Name: {Name}");
    }
}

// Derived Class (Student)
class Student : LibraryMember
{
    public string StudentID { get; set; }

    public Student(int memberId, string name, string studentId) : base(memberId, name)
    {
        StudentID = studentId;
    }

    public override void DisplayMemberInfo()

    {
        Console.WriteLine($"Student: {Name}, ID: {StudentID}, MemberID: {MemberID}");
    }
}

// Derived Class (Teacher)
class Teacher : LibraryMember
{
    public string Department { get; set; }

    public Teacher(int memberId, string name, string department) : base(memberId, name)
    {
        Department = department;
    }

    public override void DisplayMemberInfo()
    {
        Console.WriteLine($"Teacher: {Name}, Dept: {Department}, MemberID: {MemberID}");
    }
}

//Polymorphism 
class Library
{
    // Method Overloading (Compile-time Polymorphism)
    public void SearchBook(string title)
    {
        Console.WriteLine($"Searching book by Title: {title}");
    }

    public void SearchBook(string author, bool isValid)
    {
        Console.WriteLine($"Searching book by Author: {author}");
    }

    public void SearchBook(int isbn)
    {
        Console.WriteLine($"Searching book by ISBN: {isbn}");
    }
}

// Runtime Polymorphism with Method Overriding
class FineCalculator
{
    public virtual void CalculateFine(int daysLate)
    {
        Console.WriteLine($"General Fine: {daysLate * 2} INR");
    }
}

class StudentFine : FineCalculator
{
    public override void CalculateFine(int daysLate)
    {
        Console.WriteLine($"Student Fine: {daysLate * 3} INR");
    }
}

class TeacherFine : FineCalculator
{
    public override void CalculateFine(int daysLate)
    {
        Console.WriteLine($"Teacher Fine: {daysLate * 1} INR");
    }
}

//Abstraction
// Interface (Abstraction)
interface ILibraryOperations
{
    void BorrowBook();
    void ReturnBook();
}

// Abstract Class (Abstraction)
abstract class LibraryUser
{
    public abstract void GetMembershipDetails();
}

// Concrete Class implementing Interface & Abstract Class
class Librarian : LibraryUser, ILibraryOperations
{
    public override void GetMembershipDetails()
    {
        Console.WriteLine("Librarian has full access to the library system.");
    }

    public void BorrowBook()
    {
        Console.WriteLine("Librarian borrowed a book.");
    }

    public void ReturnBook()
    {
        Console.WriteLine("Librarian returned a book.");
    }
}

