using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Commander.Models
{
    public class GenderOfProductReadDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int GenderId { get; set; }
    }
}