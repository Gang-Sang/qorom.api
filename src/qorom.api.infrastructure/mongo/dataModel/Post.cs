﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qorom.api.infrastructure.mongo.dataModel
{
    internal class Post
    {
        internal int PostId { get; set; }
        internal string? Title { get; set; }
        internal string? Content { get; set; }
        internal DateTime Created { get; set; }
        internal DateTime? Updated { get; set; }
    }
}
