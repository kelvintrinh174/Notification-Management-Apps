using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _301025717_TRINH__ASS1
{
    public partial class PublishNotification : Form
    {
        private Publisher publisher;
        private NotificationManager notificationManager;

        
        public PublishNotification(Publisher publisher,NotificationManager notificationManager)
        {
            this.publisher = publisher;
            this.notificationManager = notificationManager;
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            notificationManager.Visible = true;
            Hide();
        }

        private void publish_Click(object sender, EventArgs e)
        {
            publisher.publishmsg.Invoke(notificationContent.Text);
            notificationContent.Text = "";

        }
    }
}
