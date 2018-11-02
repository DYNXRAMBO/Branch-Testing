using System;

namespace Midterm
{
    public class Book
    {
        public int BookID {get;set;} //pk
        public string Title{ get; set; }
        public string Publisher { get; set; }
        public string PublishDate { get; set; }
        public int Pages { get; set; }
        public int AuthorId { get; set; } //fk
        public Author Author { get; set; }

        public override string ToString()
        {
            string output = $"{this.Title}  {this.Publisher} {this.PublishDate} {this.Author} {this.Pages}";
            return output;
        }

    }

}