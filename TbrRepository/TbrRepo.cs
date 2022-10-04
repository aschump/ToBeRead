using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TbrContent;

namespace TbrRepository
{
    public class TbrRepo
    {
        //making List read only 
        protected readonly List<Book> _bookDirectory = new List<Book>(); 

        //Create Book
        public bool AddBookToDirectory (Book newBook)
        {
            //start to count to book directory
            //declare and initialize .Count to count what is in the _bookDirectory
            int startingCount = _bookDirectory.Count;

            //add new book
            _bookDirectory.Add(newBook);

            /*checking that the book was added to directory so if the number 
             * we have now is greater than what we started with*/
            //use terenary for loop
            bool wasAdded = (_bookDirectory.Count > startingCount) ? true : false;
            return wasAdded;

        }        

        //Get All Books
        public List<Book> GetAllBooks()
        {
            return _bookDirectory;
        }

        //Get Book By Genre
        public List<Book> GetBookByGenre(Genres genre)
        {
            List<Book> listOfBooks = new List<Book>();
            foreach (Book currentBook in listOfBooks)
            {
                if (currentBook.BookGenre == genre)
                {
                    listOfBooks.Add(currentBook);                    
                }
                return null;               
            }
            return listOfBooks;
        }
        //Get Book By Author
        public List<Book> GetBookByAuthor(int authorID)
        {
            List<Book> listofBooks = new List<Book>();
            foreach(Book currentBook in listofBooks)
            {
                if(currentBook.AuthorID == authorID)
                {
                    listofBooks.Add(currentBook);
                }
                return null;
            }

            return listofBooks;
        }
        //Get Book By Title/Keyword
        public List<Book> GetBookByTitle(string keyword)
        {
            List<Book> listofBooks = new List<Book>();
            foreach(Book currentBook in listofBooks)
            {
                if (currentBook.Title.Contains(keyword))
                {
                    listofBooks.Add(currentBook);
                }
                return null;
            }
            return listofBooks;
        }

        //Get Book By Keyword that returns a Book object instead of a list to use
        //in UpdateBook method
        public Book GetBookByKeyword(string keyword)
        {
            foreach(Book currentBook in _bookDirectory)
            {
                //to lower will make sure it recognizes the title even if they are diff cases
                if (currentBook.Title.ToLower() == keyword.ToLower())
                {
                    return currentBook;
                }                
            }
            return null;
        }
        //Update Book
        public bool UpdateBook(string bookTitle, Book newBook)
        {
            //pull up all info on current book first
            Book oldBook = GetBookByKeyword(bookTitle);  
            
            //Updating the book if it is found
            if (oldBook != null)
            {
                oldBook.AuthorID = newBook.AuthorID;
                oldBook.Title = newBook.Title;
                oldBook.BookGenre = newBook.BookGenre;
                oldBook.IsSeries = newBook.IsSeries;
                oldBook.IsRead = newBook.IsRead;

                return true;
            }
            else
            {
                return false;
            }

        }

        //Delete Book
        public bool DeleteBook(Book existingBook)
        {
            bool deleteBook = _bookDirectory.Remove(existingBook);
            return deleteBook;


        }



    }
}
