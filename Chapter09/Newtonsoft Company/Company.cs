using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonsoftCompany
{
    public class Company
    {
        public string ? companyName { get; set;}  
        public string? firstName { get; set;}
        public string? lastName { get; set; }
        public string? position { get; set; }
        public string? country { get; set; }

        public List<Company>? klas { get; set; }

        public Company() { }    
    }
}
