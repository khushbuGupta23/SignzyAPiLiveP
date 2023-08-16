using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MimeKit;
using MailKit.Net.Smtp;


namespace Signzy.ApiSandboxModification.Application.EmailService
{
  
    public  class EmailService //:IEmailService
    {
        //private readonly EmailSettings _emailSettings;

        //public EmailService(IOptions<EmailSettings> emailSettings)
        //{
        //    _emailSettings = emailSettings.Value;
        ////}
        //public async Task SendEmailAsync(string toEmail, string subject, string content)
        //{
        //    var email = new MimeMessage();
        //    email.From.Add(new MailboxAddress("Your App Name", _emailSettings.Username));
        //    email.To.Add(new MailboxAddress("", toEmail));
        //    email.Subject = subject;

        //    var bodyBuilder = new BodyBuilder();
        //    bodyBuilder.HtmlBody = content;
        //    email.Body = bodyBuilder.ToMessageBody();

        //    using var client = new SmtpClient();
        //    await client.ConnectAsync(_emailSettings.SmtpServer, _emailSettings.Port, true);
        //    await client.AuthenticateAsync(_emailSettings.Username, _emailSettings.Password);
        //    await client.SendAsync(email);
        //    await client.DisconnectAsync(true);
        //}

    }
}
