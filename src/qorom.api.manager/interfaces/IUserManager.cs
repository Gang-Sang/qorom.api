using qorom.api.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qorom.api.manager.interfaces
{
    public interface IUserManager
    {
        string GetSigningMessage(string publicKey);
        User SignInUser(string publicKey, string signedMessage);

        User GetUserSession(string publicKey, string sessionKey);
    }
}
