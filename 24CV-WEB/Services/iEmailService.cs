using _24CV_WEB.Models;

namespace _24CV_WEB.Services
{
    public interface iEmailService
    {
        bool SendEmail(string email);
        bool SendEmailWithData(EmailData data);
        bool sendEmailWithoutData(string email);

    }
}
