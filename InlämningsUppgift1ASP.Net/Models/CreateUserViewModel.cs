using InlämningsUppgift1ASP.Net.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlämningsUppgift1ASP.Net.Models
{
    public class CreateUserViewModel : ApplicationUser  
    {
        public string Password { get; set; }

    }
}
