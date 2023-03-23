using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos.Employeer
{
    public class GetEmployeerDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Job { get; set; }
        public int Phone { get; set; }
        public string? Email { get; set; }
    }
}