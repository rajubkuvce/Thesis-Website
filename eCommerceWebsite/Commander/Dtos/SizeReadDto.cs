using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Commander.Models
{
    public class SizeReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}