using TCM.Web.API.Core.Domain;

namespace TCM.Web.API.Core.Helpers
{
    public interface IAuthenticate
    {
        bool Authenticate(UserCredentials userCredentials);
    }
}