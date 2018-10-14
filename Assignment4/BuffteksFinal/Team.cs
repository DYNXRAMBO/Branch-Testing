using System;

namespace BuffteksFinal
{
    public class Team
    {
        //PK
        public int TeamID{ get; set; }
        //Team Name
        public string TeamName { get; set; }
        //FK
        public int StudentID {get; set;}

        

        public override string ToString()
        {
            string output = $"{this.TeamName}";
            return output;
        }

    }

}