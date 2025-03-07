using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Interfaces
{
    public interface ISmsService
    {
        bool SendSms(string subject, string body, List<string> phoneNumberList);
    }
}
