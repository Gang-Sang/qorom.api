using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qorom.api.model
{
    public class User
    {
        public string? PublicKey { get; set; }
        public string? Name { get; set; }
        public UserLevel Level { get; set; }
        public string? SessionKey { get; set; }

    }
}
