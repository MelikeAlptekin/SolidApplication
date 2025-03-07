using SolidApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Services
{
    public class NetMailService : IMailService
    {
        public bool SendMail(string subject, string body, List<string> to)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("bayms4441@gmail.com");

            foreach (var item in to)
            {
                ePosta.To.Add(item);
            }

            ePosta.Subject = subject;
            ePosta.Body = body;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("bayms4441@gmail.com", "Manis45");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
         


            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
                return true;
            }
            catch (Exception)
            {

                return false;
            } 

        }
    }
}
