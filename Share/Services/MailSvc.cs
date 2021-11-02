using Share.Interfaces;
using Share.Models;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Linq;
using System;
using System.Text;

namespace Share.Services
{
    public class MailSvc : IMailSvc
    {
        private readonly MailSettings _mailConfig;
        private readonly DataContext _context;
        private readonly IEncodeHelper _encodeHelper;
        public MailSvc(MailSettings mailConfig, DataContext context, IEncodeHelper encodeHelper)
        {
            _mailConfig = mailConfig;
            _context = context;
            _encodeHelper = encodeHelper;
        }

        public void SendEmailAsync(string ToEmail, string newPass)
        {
            Random random = new Random();
            string password = null;
            User user = new User();
            user = _context.Users.Where(e => e.Email == ToEmail).FirstOrDefault();
            password = user.Password;
            //SMTP: Simple Mail Transfer Protocol
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            message.From = new MailAddress(_mailConfig.FromEmail);
            message.To.Add(new MailAddress(ToEmail));
            message.Subject = "[Sac Backpack Web] Bạn đã sử dụng tính năng quên mật khẩu!";
            message.IsBodyHtml = true;
            message.Body = "Kính chào Quý Khách! Mật khẩu mới truy cập website của quý khách là: " + newPass;
            smtp.Port = _mailConfig.Port;
            smtp.Host = _mailConfig.Host;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(_mailConfig.Username, _mailConfig.Password);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
        }
    }
}