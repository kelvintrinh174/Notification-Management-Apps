using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _301025717_TRINH__ASS1
{
    public class SendViaMobile
    {
        public String CellPhone { get; set; }

        public SendViaMobile() { }

        public SendViaMobile(String phone)
        {
            CellPhone = phone;
        }

        private void sendMessage(string msg)
        {
            MessageBox.Show("The message " + "\"" + msg + "\" has already texted to " + CellPhone);
        }

        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += sendMessage;
        }

        public void UnSubscribe(Publisher pub)
        {
            pub.publishmsg -= sendMessage;
        }
    }
}
