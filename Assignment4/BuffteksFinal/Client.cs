using System;

namespace BuffteksFinal
{
    public class Client
    {
        //PK
        public int ClientID{ get; set; }
        //fk
        public int OrganizationID{ get; set; }

        //Client Name
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }



        

        public override string ToString()
        {
            string output = $"{this.FirstName} {this.LastName} ";
            return output;
        }

    }

}