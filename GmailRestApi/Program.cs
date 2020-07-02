using System;
using System.Collections.Generic;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;

namespace GmailRestApi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*var gmailService = new GService().Service();
            var gmailRepo = new Repository();
            List<Message> messages = gmailRepo.ListMessages(gmailService, "me", "");

            foreach (var message in messages)
            {
                
            }*/
            
            print("hello");
            
            Console.Read();
        }

        static void print(Object obj)
        {
            Console.WriteLine(obj);
        }
    }
}