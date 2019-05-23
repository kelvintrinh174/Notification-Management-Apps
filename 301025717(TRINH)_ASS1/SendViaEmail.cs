using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _301025717_TRINH__ASS1
{
    public class SendViaEmail
    {
        public String EmailAddr { get; set; }

        public SendViaEmail() { }

        public SendViaEmail(String emailAddr)
        {
            EmailAddr = emailAddr;
        }

        public void sendEmail(string msg)
        {
            MessageBox.Show("The message" + "\"" + msg + "\" has already sent to " + EmailAddr);
        }



        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += sendEmail;
        }

        public void UnSubscribe(Publisher pub)
        {
            pub.publishmsg -= sendEmail;
        }
    }
}
