using HRManagement.Application.Contracts.Email;
using HRManagement.Application.Models;

namespace HRManagement.Infrastructure.EmailService {


    public class EmailSender : IEmailSender
    {
        public async Task<bool> SendEmail(EmailMessage email)
        {
            Console.WriteLine("Faking Sending Email");

            return true;
        }
    }


}