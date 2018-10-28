// ============================================  Mason McCollum  ===================================


using System;
using System.Linq;
using System.Collections.Generic;



namespace ObjectOriented
{
    class Program
    {
        static public List<GradStudent> gradlist = new List<GradStudent>();
        static public List<UndergradStudent> undlist = new List<UndergradStudent>();
        static void Main(string[] args)
        {
                  
           bool exit = false;
           while(exit == false)
           {
                try
                {
                    while (exit == false)
                    {
                        Console.WriteLine("Please enter your choice");
                        Console.WriteLine("1) Add a grad student \n2) Add undergrad student\n3) List all grad students\n4) List all undergrad students\n5) Quit\n6) Add Seed data (Proof the lists were empty before)");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch(choice) 
                        {
                            case 1:
                                addGradStudent();
                                break;
                            case 2:
                                addUnderGradStudent();
                                break;
                            case 3:
                                listAllGradStudents();
                                break;
                            case 4:
                                listAllUndergradStudents();
                                break;
                            case 5:
                                Console.WriteLine("Quitting");
                                exit = true;
                                break;
                            case 6:
                                 string[] SeedGrad = System.IO.File.ReadAllLines(@"SeedGradStudents.txt");
                                foreach(string gradData in SeedGrad)
                                {
                                    string[] gData  = gradData.Split(',');
                                    var s = new GradStudent(gData[0].Trim(),gData[1].Trim(),long.Parse(gData[2]),gData[3].Trim() ,float.Parse(gData[4]), gData[5].Trim(),gData[6].Trim(),gData[7].Trim(), float.Parse(gData[8]));
                                    gradlist.Add(s);
                                    Console.WriteLine("seed data added");
                                }

                                string[] SeedUndergrad = System.IO.File.ReadAllLines(@"SeedUndGradData.txt");
                                foreach(string undgradData in SeedUndergrad)
                                {
                                    string[] eData  = undgradData.Split(',');
                                    var r = new UndergradStudent(eData[0].Trim(),eData[1].Trim(),long.Parse(eData[2]),eData[3].Trim() ,float.Parse(eData[4]), eData[5].Trim(),eData[6].Trim());
                                    undlist.Add(r);
                                    Console.WriteLine("seed data added");
                                }
                                break;
                        }
                    }
                }catch(Exception e)
                    {
                        Console.Write(e);
                        Console.WriteLine("Please Enter a Valid Response");
                    }
            } 
        }
        static void listAllUndergradStudents()
        {
            Console.WriteLine("<<Undergraduate Table>>");
            Console.WriteLine("\n\n{0,-20} {1,-11} {2,-10} {3,-10} {4, -5} {5, -20} {6, -20}","Name","DateOfBirth","ID","Major", "Grade","Previous Highschool" ,"Classification");
            Console.WriteLine("{0,-20} {1,-11} {2,-10} {3,-10} {4,-5} {5,-20} {6,-20}","--------------------","-----------","----------","----------", "-----", "-------------------", "--------------------");

            foreach(UndergradStudent uGrad in undlist ){
                uGrad.displayStdInfo();
            }
        }
        public static void addUnderGradStudent()
        {
           
            
            List<UndergradStudent> undGradList = new List<UndergradStudent>();

            string name;
            string DOB;
            long ID;
            string Mjr ;
            float grade;
            string hs;
            string sClass;
            int number;
            Console.WriteLine("please enter how many students you would like to add");
            number = int.Parse(Console.ReadLine());

            for(int i=0;i<number;i++)
            {
                Console.WriteLine("Student # {0}:",i+1);

                Console.WriteLine("Name:");
                name = Console.ReadLine();

                Console.WriteLine("Date of birth mm/dd/yyyy:");
                DOB = Console.ReadLine();

                Console.WriteLine("Id #:");
                ID  = long.Parse(Console.ReadLine());

                Console.WriteLine("Major?:");
                Mjr  = Console.ReadLine();

                Console.WriteLine("GPA?:");
                grade  = float.Parse(Console.ReadLine());

                Console.WriteLine("Previous highschool:");
                hs = Console.ReadLine();

                Console.WriteLine("Classification?:");
                sClass = Console.ReadLine();

                UndergradStudent.addStudentInfo(name, DOB,ID,Mjr,grade,hs,sClass);
                
            }
            
        }
        static void listAllGradStudents()
        {
            Console.WriteLine("Graduate Table");
            Console.WriteLine("\n\n{0,-20} {1,-11} {2,-10} {3,-10} {4, -5} {5, -5} {6, -20} {7, -20} {8, -5}","Name","DateOfBirth","ID","Major", "Grade","Previous Degree" ,"Previous University" ,"Undergrad Major" ,"Undergrad GPA" );
            Console.WriteLine("{0,-20} {1,-11} {2,-10} {3,-10} {4,-5} {5,-5} {6,-20} {7,-20} {8,-5}","--------------------","-----------","----------","----------", "-----", "---------------", "--------------------","--------------------","-----");

            foreach(GradStudent grad in gradlist ){
                grad.displayStdInfo();
            }
            
            
        }
        public static void addGradStudent()
        {
            
             
            string name;
            string DOB;
            long ID;
            string Mjr ;
            float grade;
            string prevDeg;
            string prevUni;
            string undMjr;
            float undGpa;
            int number;
            Console.WriteLine("please enter how many students you would like to add");
            number = int.Parse(Console.ReadLine());

            for(int i=0;i<number;i++)
            {
                Console.WriteLine("How many Students would you like to add:",i+1);

                Console.WriteLine("Name:");
                name = Console.ReadLine();

                Console.WriteLine("Date of birth MM/DD/YYYY:");
                DOB = Console.ReadLine();

                Console.WriteLine("Id #:");
                ID  = long.Parse(Console.ReadLine());

                Console.WriteLine("Major?:");
                Mjr  = Console.ReadLine();

                Console.WriteLine("GPA?:");
                grade  = float.Parse(Console.ReadLine());

                Console.WriteLine("Previous degree:");
                prevDeg = Console.ReadLine();

                Console.WriteLine("Previous University?:");
                prevUni = Console.ReadLine();

                Console.WriteLine("Undergrad Major?:");
                undMjr = Console.ReadLine();

                Console.WriteLine("Undergrad GPA?:");
                undGpa = float.Parse(Console.ReadLine());

                GradStudent.addStudentInfo(name, DOB,ID,Mjr,grade,prevDeg,prevUni,undMjr,undGpa);
                
                
            }
        }

        //============end====
    }
}

