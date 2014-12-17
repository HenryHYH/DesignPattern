using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.FacadePattern
{
    public class NotificationFacade
    {
        SmsSystem sms = new SmsSystem();
        EmailSystem email = new EmailSystem();

        public string Notify(int userId, string message)
        {
            string str = sms.Send(GetUserMobile(userId), message);
            str += "|" + email.Send(GetUserEmail(userId), message);

            return str;
        }

        private string GetUserEmail(int userId)
        {
            return "a@a.com";
        }

        private string GetUserMobile(int userId)
        {
            return "13800138000";
        }
    }
}
