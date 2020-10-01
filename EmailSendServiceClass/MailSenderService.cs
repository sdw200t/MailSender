using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail;

namespace EmailSendServiceClass
{
    class MailSenderService
    {
        public void SendEmail(MailMessage Message, string SmtpAdress, int SmtpPort, string Login, string Password)
        {
            SmtpClient smtp = new SmtpClient(SmtpAdress, SmtpPort);
            smtp.Credentials = new NetworkCredential(Login, Password);
            smtp.EnableSsl = true;
            smtp.Send(Message);
        }
    }
}
