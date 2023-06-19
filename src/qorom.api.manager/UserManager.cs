
using qorom.api.manager.interfaces;
using qorom.api.model;

namespace qorom.api.manager
{
    public class UserManager : IUserManager
    {
        public string GetSigningMessage(string publicKey)
        {
            throw new NotImplementedException();
        }

        public User GetUser(string publicKey)
        {
            throw new NotImplementedException();
        }

        public User SignInUser(string publicKey, string signedMessage)
        {
            throw new NotImplementedException();
        }
    }
}
