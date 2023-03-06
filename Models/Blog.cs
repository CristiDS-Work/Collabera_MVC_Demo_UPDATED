using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SitecorePoweredBlog.Models
{
    [Table("Blogs")]
    public class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string SmallImage { get; set; }
        public string BigImage { get; set; }
        public DateTime Date { get; set; }
        public string ShortText { get; set; }
        public string LongText { get; set; }
        public string Tags { get; set; }
    }
}
