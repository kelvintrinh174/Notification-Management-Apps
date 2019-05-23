using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace _301025717_TRINH__ASS1
{
    public partial class SubcribeForm : Form
    {
        private Publisher publisher;
        private NotificationManager notificationManager;
        private Button publishNotification;

        public bool IsEmailExist(string emailAddress)
        {
            foreach(SendViaEmail emails in Collection.sendViaEmails)
            {
                if(String.Equals(emailAddress,emails.EmailAddr))
                    return true;
            }
            return false;
        }

        public bool IsMobileExist(String mobileNumber)
        {
            foreach (SendViaMobile mobile in Collection.sendViaMobiles)
            {
                if (String.Equals(mobileNumber, mobile.CellPhone))
                    return true;
            }
            return false;
        }


        public SubcribeForm(Publisher publisher,NotificationManager notificationManager,Button publishNotification)
        {          
            InitializeComponent();
            this.publisher = publisher;
            this.notificationManager = notificationManager;
            this.publishNotification = publishNotification;
        }

        private void Subcribe_Click(object sender, EventArgs e)
        {
            if (messageSentByEmail.Checked)
            {
                if (RegexUtilities.IsValidEmail(emailAdress.Text))
                {
                    if (IsEmailExist(emailAdress.Text))
                        MessageBox.Show(emailAdress.Text + " was already subcribed.");
                    else
                    {
                        SendViaEmail send2Email = new SendViaEmail(emailAdress.Text);
                        Collection.sendViaEmails.Add(send2Email);
                        send2Email.Subscribe(publisher);
                        MessageBox.Show(emailAdress.Text + " was subcribed");
                    }

                }
                else
                    MessageBox.Show("Your email is not valid! It should be xxx@xxx.xxx format!");
            }
            

            if (messageSentByMobile.Checked)
            {
                if(RegexUtilities.CheckNumber(mobileNumber.Text))
                {
                    if(IsMobileExist(mobileNumber.Text))
                    {
                        MessageBox.Show(mobileNumber.Text + " was already subcribed.");
                    }
                    else
                    {
                        SendViaMobile send2Mobile = new SendViaMobile(mobileNumber.Text);
                        Collection.sendViaMobiles.Add(send2Mobile);
                        send2Mobile.Subscribe(publisher);
                        MessageBox.Show(mobileNumber.Text + " was subcribed");
                    }
                   
                }
                else
                    MessageBox.Show("Your number is not valid! It should be xxx-xxx-xxxx format");
            }
           

            emailAdress.Text = "";
            messageSentByEmail.Checked = false;
            mobileNumber.Text = "";
            messageSentByMobile.Checked = false;

        }

        private void Unscribe_Click(object sender, EventArgs e)
        {
            if (messageSentByEmail.Checked)
            {
                if(Collection.sendViaEmails.Count != 0)
                {
                    foreach (SendViaEmail value in Collection.sendViaEmails)
                    {
                        if (String.Equals(value.EmailAddr, emailAdress.Text))
                        {
                            value.UnSubscribe(publisher);
                            MessageBox.Show($"The email {value.EmailAddr} is unsubcribed");
                            Collection.sendViaEmails.Remove(value);
                            break;
                        }
                        else
                            MessageBox.Show("Your input email has not subcribed yet!");
                    }
                }

                

            }

            if (messageSentByMobile.Checked)
            {
                if (Collection.sendViaMobiles.Count != 0)
                {
                    foreach (SendViaMobile value in Collection.sendViaMobiles)
                    {
                        if (String.Equals(value.CellPhone, mobileNumber.Text))
                        {
                            value.UnSubscribe(publisher);
                            MessageBox.Show($"The number {value.CellPhone} is unsubcribed");
                            Collection.sendViaMobiles.Remove(value);
                            break;
                        }
                        else
                            MessageBox.Show("Your input mobile has not subcribed yet!");
                    }
                }



            }

            emailAdress.Text = "";
            messageSentByEmail.Checked = false;
            mobileNumber.Text = "";
            messageSentByMobile.Checked = false;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            notificationManager.Visible = true;
            if(Collection.sendViaEmails.Count != 0 || Collection.sendViaMobiles.Count!=0)
                publishNotification.Enabled = true;
            else
                publishNotification.Enabled = false;

            Hide();
        }

    }

    //this code is from https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
    public class RegexUtilities
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        //this code is from http://www.authorcode.com/how-to-use-regular-expression-for-validating-phone-numbers-in-net/
        public static bool CheckNumber(string strPhoneNumber)
        {
            string MatchPhoneNumberPattern = @"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$";
            if (strPhoneNumber != null) return Regex.IsMatch(strPhoneNumber, MatchPhoneNumberPattern);
            else return false;
        }

    }

}
