using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SMS
{
    public class SmsSender
    {
        private ISms _ISms;
        public SmsSender(ISms ms)
        { _ISms = ms; }
        public void Send(string message, string mobile)
        {
            _ISms.Send(message, mobile);
        }

    }
}
