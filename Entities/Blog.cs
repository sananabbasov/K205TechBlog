using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Blog : Base
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public int Hit { get; set; }
        public string SeoUrl { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
