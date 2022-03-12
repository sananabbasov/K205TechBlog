using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Comment : Base
    {
        public string CommentText { get; set; }
        public string K205UserId { get; set; }
        public K205User K205User { get; set; }
    }
}
