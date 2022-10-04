using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TbrContent
{
    public class Author
    {
        [Key]
        public int authorID { get; set; } //PK
        public string AuthorName { get; set; }
        
        /*look up how to ensure a list of the books associated 
        with this authorID will populate*/
        //public Book AuthorBooks { get; set; }


    }
}
