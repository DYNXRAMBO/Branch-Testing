using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Midterm
{
    public class Author
    {
    public int AuthorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    


    public override string ToString()
    {
        string output = $"{this.FirstName}  {this.LastName} ";
        return output;
    }

    }

}