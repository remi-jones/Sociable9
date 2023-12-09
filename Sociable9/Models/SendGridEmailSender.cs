using Microsoft.AspNetCore.Identity.UI.Services;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

public class SendGridEmailSender : IEmailSender
{
    private readonly string _sendGridKey;

    public SendGridEmailSender(IConfiguration configuration)
    {
        _sendGridKey = configuration["SendGrid:ApiKey"];
    }

    public async Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        var client = new SendGridClient(_sendGridKey);
        var from = new EmailAddress("noreply.sociable@gmail.com", "Sociable");
        var to = new EmailAddress(email);
        var msg = MailHelper.CreateSingleEmail(from, to, subject, htmlMessage, htmlMessage);
        await client.SendEmailAsync(msg);
    }
}