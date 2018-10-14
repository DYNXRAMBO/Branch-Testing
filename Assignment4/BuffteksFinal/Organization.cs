using System;

namespace BuffteksFinal
{
    public class Organization
    {
        public int OrganizationID{ get; set; } //pk
        public int ClientID{ get; set; } //fk

        //Org Name
        public string OrganizationName { get; set; }

        

        public override string ToString()
        {
            string output = $"{this.OrganizationName}";
            return output;
        }

    }

}