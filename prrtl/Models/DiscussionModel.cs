using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prrtl.Models
{
    public class DiscussionModel
    {
        public List<DiscussionItems> Discussions { get; set; }
        public DiscussionItems Discussion { get; set; }
    }

    public class DiscussionItems 
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string User { get; set; } //Account username
        public DateTime PostTime { get; set; }
    }
}