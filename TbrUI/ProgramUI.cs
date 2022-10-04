using System;
using System.Collections.Generic;
using System.Text;
using TbrContent;

namespace TbrUI
{
    public class ProgramUI
    {
        //creat field for repo
        private readonly Book _bookrepo = new Book();
        //private readonly Book
        public void Run()
        {
            SeedContentList();
            RunMenu();
        }


        public void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Welcome to your bookshelf. Please enter the number of the option you want to select:\n" +
                    "1: Add new book\n" +
                    "2: View all my books\n" +
                    "3: Searh by Author\n" +
                    "4: Search by Genre\n" +
                    "5: Search by Title\n" +
                    "6: Delete a book");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        CreateNewBook();
                        break;
                    case "2":
                        ShowAllBooks();
                        break;
                    case "3":
                        ShowAllBooksByAuthor();
                        break;
                    case "4":
                        ShowAllBooksByGenre();
                        break;
                    case "5":
                        ShowAllBooksByTitle();
                        break;
                    case "6":
                        DeleteBook();
                        break;
                    default:
                        Console.WriteLine("Uh oh. Please enter a valid number between 1-6\n" +
                            "Press any key to try again");
                        Console.ReadKey();
                        break;                 
                      
                }
           
            }            
        }

        private void CreateNewBook()
        {
            Console.Clear();

            Book book = new Book();

            Console.WriteLine("Please follow the instructions to add a new book.\n" +
                "Please enter a title");
            book.Title = Console.ReadLine();

            //Console.WriteLine("Please enter the name of the author:");
            //book.AuthorID = Console.ReadLine();

            Console.WriteLine("Please select a genre using the following options:\n" +
                "1: Romance\n" +
                "2: Mystery\n" +
                "3: Thriller\n" +
                "4: Teen Fiction\n" +
                "5: Action/Adventure\n" +
                "6: Science Fiction\n" +
                "7: Autobiography");
            string bookGenre = Console.ReadLine();
            switch (bookGenre)
            {
                case "1":
                    book.BookGenre = Genres.Romance;
                    break;
                case "2":
                    book.BookGenre = Genres.Mystery;
                    break;
                case "3":
                    book.BookGenre = Genres.Thriller;
                    break;
                case "4":
                    book.BookGenre = Genres.TeenFiction;
                    break;
                case "5":
                    book.BookGenre = Genres.ActionAdventure;
                    break;
                case "6":
                    book.BookGenre = Genres.ScienceFiction;
                    break;
                case "7":
                    book.BookGenre = Genres.Autobiography;
                    break;
                default:
                    Console.WriteLine("Please enter a valid number between 1 and 7\n" +
                        "Press any key to continue............");
                    Console.ReadKey();
                    break;
                    
            }

            Console.WriteLine("Is this book a part of a series? Enter true or false:");
            book.IsSeries = Convert.ToBoolean(Console.ReadLine());
        }

        private void ShowAllBooks()
        {
            Console.Clear();
            Console.WriteLine("All Books");
            //creante new instance of the list of books and set it equal to the fiels and GetAllBooks method , will use Helper method to display books
            List<Book> listOfBooks = new List<Book>();
            foreach (Book book in listOfBooks)
            {
                DisplayBook(book);
            }            
        }

        private void ShowAllBooksByAuthor()
        {
            throw new NotImplementedException();
        }

        private void ShowAllBooksByGenre()
        {
            throw new NotImplementedException();
        }

        private void ShowAllBooksByTitle()
        {
            throw new NotImplementedException();
        }

        private void DeleteBook()
        {
            throw new NotImplementedException();
        }


        private void SeedContentList()
        {
            Book gladMyMomDied = new Book("I'm Glad My Mom Died", );
        }

        public void DisplayBook(Book book)
        {
            Console.WriteLine($"Title: {book.Title}\n" +
                $"Author: {book.AuthorID}\n" +
                $"Book Genre: {book.BookGenre}\n" +
                $"Is in a Series: {book.IsSeries}\n" +
                $"Already read: {book.IsRead}");
        }
    }
}
