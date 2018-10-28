// ============================================  Mason McCollum  ===================================


using System;

namespace ObjectOriented
{
    public class UndergradStudent:Student
    {
        string previousHshool {get;set;}
        string stdClass {get;set;}


         public UndergradStudent(string StudName, string DateOfBirth, long StudID, string Major, float GPA, string previousHshool,string stdClass):base (StudName,DateOfBirth,StudID,Major,GPA)
        {
            this.previousHshool = previousHshool;
            this.stdClass = stdClass;
        }
        public static void addStudentInfo(string name, string DOB,long ID,string Mjr,float grade,string previousHighschool,string stdClass)
        {
            UndergradStudent s1 = new UndergradStudent(name, DOB,ID,Mjr,grade,previousHighschool,stdClass );
            Program.undlist.Add(s1);
        }
        public override void updateStdInfo()
        {
        }
        public override void displayStdInfo()
        {
            base.displayStdInfo();
            Console.WriteLine("{0,-20:F2} {1,-30:F2} ",previousHshool, stdClass  );
        }
    }
}