using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class Room
    {
        public Room()
        {
            Students = new HashSet<Student>();
        }

        public Room(int floorNumber, int roomNumber, int size, string name) : this()
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
            Size = size;
            Name = name;
        }

        public int Id { get; set; }
        public int FloorNumber { get; set; }
        public int RoomNumber { get; set; }
        public int Size { get; set; }
        public string Name { get; set; }

        public void PrintData()
        {
            Console.WriteLine($"Room N {RoomNumber} has {Size} seats. It is Called {Name}. It is located on Floor {FloorNumber}");
        }
        public virtual ICollection<Student> Students { get; set; }
    }
}
