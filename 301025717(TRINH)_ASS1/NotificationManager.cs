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

    public partial class NotificationManager : Form
    {
        Publisher publisher = new Publisher();

        public NotificationManager()
        {
            InitializeComponent();
            publishNotification.Enabled = false;
        }

        private void manageSubcription_Click(object sender, EventArgs e)
        {
            SubcribeForm mySubcribeForm = new SubcribeForm(publisher, this, publishNotification);
            mySubcribeForm.Show();
            Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PublishNotification_Click(object sender, EventArgs e)
        {         
            PublishNotification myPublicNotification = new PublishNotification(publisher,this);
            myPublicNotification.Show();
            Hide();
        }
    }

    public static class Collection
    {
        public static List<SendViaEmail> sendViaEmails = new List<SendViaEmail>();

        public static List<SendViaMobile> sendViaMobiles = new List<SendViaMobile>();
    }

}
