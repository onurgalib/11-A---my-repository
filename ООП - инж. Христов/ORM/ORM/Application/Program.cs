using Application.Data;
using Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Application
{
    internal class Program
    {
        static void Main()
        {
            using (AppDbContext db=new AppDbContext())
            {
                //  InsertData(db);

                var studentFd = db.Students.FirstOrDefault(x => x.Name == "Trifon");
                studentFd.GSM = "+359838383869";
                studentFd.Email = "slavi@trifonov.abv.bg";

                db.Update(studentFd);
                db.SaveChanges();

                Student[] students = db.Students.Include(s => s.Room).ToArray();               
                Console.WriteLine();
            }





        }

        private static void InsertData(AppDbContext db)
        {
            var room = new Room(2, 27, 13, "Master Hall");
            var person1 = new Student("Genadi", 11, 'A');
            person1.Room = room;
            person1.Email = "genadi@abv.bg";
            person1.GSM = "+359888888888";

            var person2 = new Student("Trifon", 12, 'A');
            person2.Room = room;
            person2.Email = "genadi@abv.bg";
            person2.GSM = "+359888888888";

            // room.Students.Add(person);
            var newStudents = new[] { person1, person2 };
            db.Students.AddRange(newStudents);            
            db.SaveChanges();
            Console.WriteLine("Gotovo!");
        }
    }
}