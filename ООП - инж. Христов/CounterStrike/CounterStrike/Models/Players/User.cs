using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CounterStrike.Contracts;

namespace CounterStrike.Models
{
    public class User : IPlayer
    {
        public User(int id, string userName, string email)
        {
            Id = id;
            UserName = userName;
            Email = email;
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }

}