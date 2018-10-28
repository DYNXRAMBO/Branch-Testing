// ============================================  Mason McCollum  ===================================


using System;

namespace ObjectOriented
{
     public class Student
    {
        internal string StudName {get;set;}
        internal string DateOfBirth {get;set;}
        internal long StudID {get;set;}
        internal string Major {get;set;}
        internal float GPA {get;set;}
    
        public Student(string StudName, string DateOfBirth, long StudID, string Major, float GPA)
        {
            this.StudName = StudName;
            this.DateOfBirth = DateOfBirth;
            this.StudID = StudID; 
            this.Major = Major;
            this.GPA = GPA;
        }
        public void addStudentInfo()
        {
            
        }
        public virtual void updateStdInfo()
        {
        }
        public virtual void displayStdInfo()
        {
            Console.Write("{0,-20} {1,-11} {2,-10} {3,-10} {4,-6}", StudName, DateOfBirth, StudID,Major, GPA);
        }
    }
}