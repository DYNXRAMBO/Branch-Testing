using System;
using System.Collections.Generic;
using System.Linq;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                try{
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                if(!db.Books.Any())
                { 
                    var adamFreeman = new Author
                    {
                        FirstName = "Adam",
                        LastName = "Freeman"
                        
                    };
                    var haishiBai = new Author
                    {
                        FirstName = "Haishi",
                        LastName = "Bai"
                        
                    };

                    List<Book> books = new List<Book>()
                    {
                        new Book()
                        {
                            Title = "Pro ASP>NET Core MVC 2 7th Edition",
                            Publisher = "Apress",
                            PublishDate = "October 25, 2017",
                            Author = adamFreeman,
                            Pages = 1017
                        },
                        new Book()
                        {
                            Title = "Pro Angular 6 3rd Edition",
                            Publisher = "Apress",
                            PublishDate = "October 10, 2018",
                            Author = adamFreeman,
                            Pages = 776
                        },
                        new Book()
                        {
                            Title = "Programming Microsoft Azure Service Fabric (Developer Reference) 2nd Edition",
                            Publisher = "Microsoft Press",
                            PublishDate = "May 25, 2018",
                            Author = haishiBai,
                            Pages = 528
                        },                        
                    };
                    db.Books.AddRange(books);  
                    db.SaveChanges();
                }
            }
                catch(Exception c)
                {
                    Console.WriteLine($"{c}");
                }
            }
        
            using(var db = new AppDbContext())
            {
                Console.WriteLine("========== Where 1 ==========");

                var Where1 = db.Books.ToList();
                var allBooks = Where1.Where(x => x.Title.Length >= 0);
                foreach(Book b in allBooks)
                {
                    Console.WriteLine("\n>>{0}",b);
                }
                
                Console.WriteLine("========== Where 2 ==========");
                
                var Where2 = db.Books.ToList();
                var allBooks1 = Where2.Where(x => x.Publisher =="Apress");
                foreach(Book b in allBooks1)
                {
                    Console.WriteLine("\n>>{0}",b);
                }
                
                 Console.WriteLine("========== Where3 ==========");
                
                var where3 = db.Books.ToList();
                var bookList = where3.Where(x => x.Author.FirstName == "Adam").Single();
                Console.WriteLine(bookList.Title);
                
                Console.WriteLine("=============== FIND ===============");
                Console.WriteLine("========== Find 1 ==========");

                var Find1 = db.Books.ToList();
                Console.WriteLine("\n>>{0}", 
                Find1.Find(x => x.Author.FirstName == "Adam"));
                 

                Console.WriteLine("========== Find 2 ==========");

                var Find2 = db.Books.ToList();
                Console.WriteLine("\n>>{0}", 
                Find2.Find(x => x.Pages >= 100));
                
                Console.WriteLine("=============== ORDERBY ===============");

                Console.WriteLine("========== OrderBy1 ==========");

                
                var orderBy1 = db.Books.ToList();
                var allBooks4 = orderBy1.OrderByDescending(x => x.Publisher);
                foreach(Book b in allBooks4)
                {
                    Console.WriteLine("\n>>{0}",b);
                }
                
                Console.WriteLine("========== OrderBy2 ==========");

                var orderBy2 = db.Books.ToList();
                var allBooks5 = orderBy2.OrderBy(x => x.Author).OrderByDescending(x => x.Publisher);
                foreach(Book b in allBooks5)
                {
                    Console.WriteLine("\n>>{0}",b);
                }
                
                Console.WriteLine("=============== ORDERBY/GROUPBY ===============");
                Console.WriteLine("========== OrderBy/GroupBy1 ==========");
                
                var orderGroup1 = db.Books.ToList();/*
                var allBooks6 = orderGroup1.GroupBy(x => x.Publisher);
                foreach(Book b in allBooks6)
                {
                    Console.WriteLine("\n>>{0}",b);
                }
                */
                var orderBy111111 = from book in orderGroup1
                                    group book by book.Publisher;
                foreach (Book b in orderBy111111)
                {
                    Console.WriteLine("\n>>{0}",b);
                }
                Console.WriteLine("========== OrderBy/GroupBy2 ==========");
                var orderGroup2 = db.Books.ToList();
                var allBooks7 = orderGroup2.OrderBy(x => x.Author).GroupBy(x => x.Publisher);
                foreach(Book b in allBooks7)
                {
                    Console.WriteLine("\n>>{0}",b);
                }
            }
        }
    }
}
