using System;

using System.Collections.Generic;
using System.Linq;

namespace BuffteksFinal
{
    class Commands
    {
        public static void studentCreate()
        {
            using(var db = new AppDbContext())
            {
                Console.WriteLine("Please Enter the first Name");
                string firstName = Console.ReadLine();
                Console.WriteLine("Please Enter the Last Name");
                string lastName = Console.ReadLine();
                Console.WriteLine("Please Enter the role");
                string role = Console.ReadLine();
                Console.WriteLine("Please Enter the email");
                string email = Console.ReadLine();
                Console.WriteLine("Please Enter the phone number");
                string phoneNumber = Console.ReadLine();
                List<Student> students = new List<Student>()
                {
                    new Student()
                    {
                    FirstName = firstName,
                    LastName = lastName,
                    PhoneNumber = phoneNumber,
                    Email = email,
                    Role = role
                    },
                };
                db.Students.AddRange(students);  
                db.SaveChanges();
            }
        }
        public static void teamsSort()
        {
            using(var db = new AppDbContext())
            {
                var teams = db.Teams.ToList();
                Console.WriteLine(">>Here are the teams sorted Decending<<");
                var teamsDecending = teams.OrderByDescending(x => x.TeamName);
                foreach(Team t in teamsDecending)
                {
                    Console.WriteLine(t);
                }
            }
        }
        public static void studentGroup()
        {
            using(var db = new AppDbContext())
            {
            var students = db.Students.ToList();
            var studentsByRole = students.OrderByDescending(x => x.Role);
            foreach(Student t in studentsByRole)
            {
                    Console.WriteLine(t);
            }
            }
        }












    }
    





}
