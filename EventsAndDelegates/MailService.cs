using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class MailService
    {
        public void DoMail(String str)
        {
            Console.WriteLine("Mail : "+str);
        }
    }
}
