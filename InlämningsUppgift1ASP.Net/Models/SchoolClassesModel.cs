using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlämningsUppgift1ASP.Net.Models
{
    public class SchoolClassesModel
    {
        public string Id { get; set; }

        public TeacherModel Teacher { get; set; }

        public virtual ICollection<StudentModel> Sudents { get; set; }  
    }
}
