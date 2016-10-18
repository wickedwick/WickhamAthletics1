using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WickhamAthletics.Models;
using System.Net.Mail;
using System.Threading.Tasks;

namespace WickhamAthletics.Services
{
    public class EmailService
    {
        //Asynchronous method to send email based on ContactForm object
        public async static Task SendContactForm(EmailModel contactForm)
        {
            //Constructing the email
            string body = "<p>The following is a message from {0} ({1})</p><p>{2}</p>";
            MailMessage message = new MailMessage();
            message.To.Add(new MailAddress("ryan@wickhamathletics.com"));
            message.Subject = "Contact Form Message";
            message.Body = string.Format(body, contactForm.Name, contactForm.From, contactForm.Body);
            message.IsBodyHtml = true;
            message.From = new MailAddress("ryan@wickhamathletics.com");

            //Attempting to send the email
            using (SmtpClient smtpClient = new SmtpClient())
            {
                await smtpClient.SendMailAsync(message);
            }
        }
    }
}