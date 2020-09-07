using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionMake
{
    class MailS
    {

        public static bool SendMessage(string message, string from, string password, string to)
        {

            MailMessage empMessage = new MailMessage(from, to);
            empMessage.Subject = String.Format("Привет Бодя");

            empMessage.Body = message;

            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(from, password);
   
            try
            {
                client.Send(empMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                    ex.ToString());
            }

            return true;
        }
    }
}
