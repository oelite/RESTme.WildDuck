using System.Threading.Tasks;
using OElite.Restme.WildDuck.Models.Authentication.TransferObjects;

namespace OElite.Restme.WildDuck.Apis
{
    public static class WdAuthenticationApi
    {
        private static string ApiPath(string path = null, string prefix = "authenticate")
        {
            return WildDuckApi.ApiPath(path, prefix);
        }

        public static Task<AuthenticateUserResult> AuthenticateUserAsync(this WildDuckApi api,
            AuthenticateUserRequest request)
        {
            using var rest = api.Restme();
            return rest.PostAsync<AuthenticateUserResult>(ApiPath(), request);
        }
        
    }
}