using System;
using System.Collections.Generic;
using System.Linq;

namespace BuffteksFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                try
                {

                    //no matter what, delete and then create
                    //db.Database.EnsureDeleted();
                    db.Database.EnsureCreated();

                    if(!db.Students.Any())
                    {
                        List<Student> students = new List<Student>()
                        {
                            new Student()
                            {
                                FirstName = "Jeffry",
                                LastName = "Babb",
                                PhoneNumber = "123-555-1234",
                                Email = "test1@test.com",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Joe",
                                LastName = "Smith",
                                PhoneNumber = "456-684-4684",
                                Email = "fun@aol.com",
                                Role = "Sophomore"
                            },
                            new Student()
                            {
                                FirstName = "Jane",
                                LastName = "Doe",
                                PhoneNumber = "123-555-1234",
                                Email = "janestudent@buffs.wtamu.edu",
                                Role = "Freshman"
                            },                        
                        };

                        db.Students.AddRange(students);  

                        db.SaveChanges();                                              

                    }
                    else
                    {
                        var students = db.Students.ToList();

                        var studentsFiltered = students.Where(s => s.FirstName.Length >= 5);
                        foreach(Student s in studentsFiltered)
                        {
                            Console.WriteLine(s);
                        }
                    }


                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
        }
    }
}
