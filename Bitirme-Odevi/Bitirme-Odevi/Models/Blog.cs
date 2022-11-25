using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bitirme_Odevi.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string BlogCategory { get; set; }
        public string Header { get; set; }
        public string Content_ { get; set; }
        public string BlogImg { get; set; }

    }
}