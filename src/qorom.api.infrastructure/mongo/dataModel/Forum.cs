using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qorom.api.infrastructure.mongo.dataModel
{
    internal class Forum
    {
        internal int ForumId { get; set; }
        internal string Name { get; set; }
        internal string Description { get; set; }
        internal string? CategoryName { get; set; }
    }
}
