using HRManagement.Application.Models;

namespace HRManagement.Application.Contracts.Email {



public interface IEmailSender {


    Task<bool> SendEmail(EmailMessage email);


}



}