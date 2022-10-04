using System;
using System.Collections.Generic;
using System.ComponentModel; //for the description attribute in the enums
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TbrContent
{
    public enum Genres { Romance = 1, Mystery, Thriller, [Description("Teen Fiction")] TeenFiction, [Description("Action & Adventure")] ActionAdventure, [Description("Science Fiction")] ScienceFiction, Autobiography};
    public class Book
    {
        [Key]
        public int BookID { get; set; } //PK

        [ForeignKey(nameof(Author))]
        public int AuthorID { get; set; } //FK

        public string Title { get; set; }
        //public string Genre { get; set; }
        public Genres BookGenre { get; set; }
        public bool IsSeries { get; set; }
        public bool IsRead { get; set; }

        //blank constructor to fill out our own
        public Book()
        {

        }
        public Book(Author author, string title, Genres bookGenre, bool isSeries, bool isRead)
        {
            AuthorID = 
        }
    }

}
