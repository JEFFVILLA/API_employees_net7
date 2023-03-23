using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Employeer
    {
        public int Id { get; set; } // Primary Key
        public string? Name { get; set; } = "Jeffri";
        public string? Job { get; set; } = "Programmer";
        public int Phone { get; set; } = 600338718;
        public string? Email { get; set; } = "jeffvilla@gmail.com";
        public User? User { get; set; }
    }
}