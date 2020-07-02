using System;
using System.Collections.Generic;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;

namespace GmailRestApi
{
    public interface IRepository
    {
        List<Message> ListMessages(GmailService service, String userId, String query);
        
    }
}