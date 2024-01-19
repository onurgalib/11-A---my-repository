using System.ComponentModel.DataAnnotations;

namespace Application.Models
{
    public class Student
    {
        public int Id { get; set; }
        public Student()
        {

        }
        public Student(string name, int grade, char gradeLetter) : this()
        {
            Name = name;
            Grade = grade;
            GradeLetter = gradeLetter;
        }

        public string Name { get; set; }
        public int Grade { get; set; }
        public char GradeLetter { get; set; }

        [MinLength(16),Phone]
        public string GSM { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        //FK
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }


    }
}
