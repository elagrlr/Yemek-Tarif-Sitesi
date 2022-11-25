using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bitirme_Odevi.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RecipeId { get; set; }
        public string Comment_ { get; set; }
    }
}