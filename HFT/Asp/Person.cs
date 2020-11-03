using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp05.Models
{
    public enum PersonType
    {
        student, teacher, visitor
    }
    public class Person
    {
        [Key]
        public string Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsPaid { get; set; }
        public PersonType Type { get; set; }
        public virtual ICollection<Keyword> KeyWords { get; set; }
    }
}
