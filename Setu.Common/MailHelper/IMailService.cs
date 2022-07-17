using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Setu.Common.MailHelper
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
