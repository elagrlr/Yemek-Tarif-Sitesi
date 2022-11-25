using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bitirme_Odevi.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string MenuName { get; set; }
        public int MenuCategory { get; set; }
        public int Menu1Id { get; set; }
        public int Menu2Id { get; set; }
        public int Menu3Id { get; set; }
        public int Menu4Id { get; set; }
        public int Menu5Id { get; set; }
    }
}