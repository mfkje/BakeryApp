using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;

namespace BakeryApp.Models
{
    public class SendMail : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            using (MailMessage mailMessage = new MailMessage())
            {
                SmtpClient smtp = new SmtpClient();

                mailMessage.From = new MailAddress("showAll234875115@gmail.com");
                mailMessage.To.Add("allerauq@gmail.com");
                mailMessage.Body = "<p>Email: "+ email +"</p>" + "<p>Message" + htmlMessage + "</p>";
                mailMessage.IsBodyHtml = true;

                smtp.Port = 587;
                smtp.Host = "smtp.simply.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("showAll234875115@gmail.com", "Pablo4!..");
                //System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();
                //NetworkCred.UserName = "showAll234875115@gmail.com";
                //NetworkCred.Password = "Pablo4!..";
                
                //smtp.Credentials = NetworkCred;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                _ = smtp.SendMailAsync(mailMessage);
            }

        }
    }
}
