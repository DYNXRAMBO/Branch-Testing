using System;
using System.Collections.Generic;
using System.Linq;

namespace BuffteksFinal
{
    class Program
    {
        static bool Exit = false;
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                if(!db.Students.Any())
                {
                    List<Student> students = new List<Student>()
                    {
                        new Student()
                        {
                            FirstName = "Abagail",
                            LastName = "Adams",
                            PhoneNumber = "567-525-1234",
                            Email = "aadams@test.com",
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
                if(!db.Teams.Any())
                {
                    List<Team> teams = new List<Team>()
                    {
                        new Team()
                        {
                            TeamName = "PC Master Race"
                        },
                        new Team()
                        {
                            TeamName = "Lords of Laptops"
                        },
                        new Team()
                        {
                            TeamName = "Gogurt Gods"
                        },                        
                    };  
                    db.Teams.AddRange(teams);
                    db.SaveChanges();
                }
                if(!db.Clients.Any())
                {
                    List<Client> clients = new List<Client>()
                    {
                        new Client()
                        {
                            FirstName = "Amanda",
                            LastName = "Roberts",
                            Email = "aroberts@test.com"
                        },
                        new Client()
                        {
                            FirstName = "Jordan",
                            LastName = "Peterson",
                            Email = "jpeterson@test.com"
                        },
                        new Client()
                        {
                            FirstName = "Makayla",
                            LastName = "dunley",
                            Email = "mdunley@test.com"
                        },                        
                    };  
                    db.Clients.AddRange(clients);
                    db.SaveChanges();
                }
                if(!db.Organizations.Any())
                
                    {
                        List<Organization> organizations = new List<Organization>()
                        {
                            new Organization()
                            {
                                OrganizationName = "Walmart"
                            },
                            new Organization()
                            {
                                OrganizationName = "KMart"
                            },
                            new Organization()
                            {
                                OrganizationName = "United"
                            },                        
                        };  
                        db.Organizations.AddRange(organizations);
                        db.SaveChanges();
                    }
                while(Exit == false)
                {
                    try
                    {
                        Console.WriteLine("Would you like to Create/Search/Sort/Group/exit (1/2/3/4/5)");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch(choice)
                        {
                            case 1:
                                Commands.studentCreate();
                                break;

                            case 2:
                                Console.WriteLine("Functionality never implemented, sorry");
                                break;

                            case 3:
                                Commands.teamsSort();
                                break;

                            case 4:
                                Commands.studentGroup();
                                break;

                            case 5:
                                Console.WriteLine("Goodbye");
                                Exit = true;
                                break;


                        }
                        
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Something went wrong");
                    }


                }
                    
            }
        }
    }
}
