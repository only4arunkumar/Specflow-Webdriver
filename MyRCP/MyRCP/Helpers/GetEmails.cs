using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AE.Net.Mail;

namespace MyRCP.Helpers
{
    
  public  class GetEmails
    {
      ImapClient client = new ImapClient();

      
        private static void Main()
        {
            var items = ReadMail();
            if (items != null && items.Count > 0)
            {
                foreach (var item in items.Take(10))
                {
                    Console.WriteLine(item.Subject);
                }
            }
            Console.ReadLine();
        }
        public static List<MailMessage> ReadMail()
        {
            List<MailMessage> messages = null;
            try
            {
                string userName = "rcpautomationuser@gmail.com"; // Replace with your actual gmail id
                string passWord = "password"; // Replace with your password

                if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(passWord))
                {
                    using (var imapClient =
                        new ImapClient("imap.gmail.com", userName, passWord, ImapClient.AuthMethods.Login, 993, true))
                    {
                        imapClient.SelectMailbox("INBOX");

                        MailMessage[] mm = imapClient.GetMessages(0, 100, false, true);

                        Console.WriteLine("IMAP:Found" + mm.Count() + "messages in inbox");


                         messages = new List<MailMessage>(imapClient.GetMessageCount());
                         messages = imapClient.GetMessages(0, 100, false, true).ToList();
                         imapClient.Disconnect();
                    }
                }
                else
                {
                    Console.WriteLine("Username or Password is empty!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return messages;
        }
         }
}
