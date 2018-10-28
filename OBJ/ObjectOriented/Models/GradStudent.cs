// ============================================  Mason McCollum  ===================================


using System;

namespace ObjectOriented
{
    public class GradStudent : Student
    {
        string PreviousDegree {get;set;}
        string PreviousUniversity {get;set;}
        string UndergradMajor {get;set;}
        float UndergradGpa {get;set;}
        
        public GradStudent(string StudName, string DateOfBirth, long StudID, string Major, float GPA, string previousDegree,string previousUniversity, string undergradMajor, float undergradGpa)
            :base (StudName,DateOfBirth,StudID,Major,GPA)
        {
            PreviousDegree = previousDegree;
            PreviousUniversity = previousUniversity;
            UndergradMajor = undergradMajor; 
            UndergradGpa = undergradGpa;
        }

        public static void addStudentInfo(string name,string DOB,long ID,string Mjr,float grade, string prevDeg,string prevUni,string undMjr,float undGpa)
        {
            GradStudent s1 = new GradStudent(name, DOB,ID,Mjr,grade,prevDeg,prevUni,undMjr,undGpa );
            Program.gradlist.Add(s1);
        }

        public override void updateStdInfo()
        {
            
        }
        public override void displayStdInfo()
        {
            base.displayStdInfo();
            Console.WriteLine("{0,-15:F2} {1,-20:F2} {2,-20:F2} {3,-5:F2}", PreviousDegree, PreviousUniversity, UndergradMajor, UndergradGpa);
        }

    }
}