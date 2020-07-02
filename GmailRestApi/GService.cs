using System;
using System.IO;
using System.Threading;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace GmailRestApi
{
    public class GService
    {
        
        private readonly string[] _scopes = { GmailService.Scope.GmailReadonly };
        private const string AppName = "Gmail Api";
        private readonly UserCredential _userCredential;
        
        
        public GService()
        {
            _userCredential = _GetCredentials();
        }

        private UserCredential _GetCredentials()
        {
            using var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read);
            string credPath = "token.json";
            var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                GoogleClientSecrets.Load(stream).Secrets,
                _scopes,
                "user",
                CancellationToken.None,
                new FileDataStore(credPath, true)).Result;

            return credential;

        }

        public GmailService Service()
        {
            return new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = _userCredential,
                ApplicationName = AppName,
            });
        }
        
    }
}