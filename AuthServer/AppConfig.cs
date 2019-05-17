using IdentityServer4.Models;
using System.Collections.Generic;

namespace AuthServer
{
    public class AppConfig
    {
        public static class ApiConfig
        {

            public static IEnumerable<ApiResource> GetApiResources()
            {
                return new[]
                {
                new ApiResource("OcelotApi", "OcelotApi")
            };
            }

            public static IEnumerable<Client> GetClients()
            {
                return new[]
                {
                new Client
                {
                    ClientId = "chathuranga",
                    ClientSecrets = new [] { new Secret("sandun".Sha256()) },
                    AllowedGrantTypes = IdentityServer4.Models.GrantTypes.ClientCredentials,
                    AllowedScopes = new [] { "OcelotApi" }
                }
            };
            }
        }
    }
}
