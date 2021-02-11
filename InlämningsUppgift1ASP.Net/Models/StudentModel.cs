using InlämningsUppgift1ASP.Net.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InlämningsUppgift1ASP.Net.Models
{
    public class StudentModel
    {
        [Required]
        [Key]
        public Guid Id { get; set; }

        public ApplicationUser Student { get; set; }

    }
}
