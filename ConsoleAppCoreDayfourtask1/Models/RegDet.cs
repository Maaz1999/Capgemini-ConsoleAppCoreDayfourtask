using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleAppCoreDayfourtask1.Models
{
    public partial class RegDet
    {
        public int Rid { get; set; }
        public string FirstName { get; set; }
        public string Mailid { get; set; }
        public string Contactno { get; set; }
        public int? Expr { get; set; }
        public string Skillset { get; set; }
    }
}
