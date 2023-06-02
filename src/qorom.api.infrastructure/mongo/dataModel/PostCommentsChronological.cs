using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qorom.api.infrastructure.mongo.dataModel
{
    internal class PostCommentsChronological
    {
        internal int PostCommentId { get; set; }
        internal int PostId { get; set; }
        internal string[]? Comments { get; set; }
    }
}
