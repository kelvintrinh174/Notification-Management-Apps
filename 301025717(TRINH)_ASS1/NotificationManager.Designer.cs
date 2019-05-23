namespace _301025717_TRINH__ASS1
{
    partial class NotificationManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.manageSubcription = new System.Windows.Forms.Button();
            this.publishNotification = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageSubcription
            // 
            this.manageSubcription.Location = new System.Drawing.Point(12, 37);
            this.manageSubcription.Name = "manageSubcription";
            this.manageSubcription.Size = new System.Drawing.Size(119, 32);
            this.manageSubcription.TabIndex = 0;
            this.manageSubcription.Text = "Manage Subcription";
            this.manageSubcription.UseVisualStyleBackColor = true;
            this.manageSubcription.Click += new System.EventHandler(this.manageSubcription_Click);
            // 
            // publishNotification
            // 
            this.publishNotification.Location = new System.Drawing.Point(146, 37);
            this.publishNotification.Name = "publishNotification";
            this.publishNotification.Size = new System.Drawing.Size(119, 32);
            this.publishNotification.TabIndex = 1;
            this.publishNotification.Text = "Publish Notification";
            this.publishNotification.UseVisualStyleBackColor = true;
            this.publishNotification.Click += new System.EventHandler(this.PublishNotification_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(283, 37);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(119, 32);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // NotificationManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 108);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.publishNotification);
            this.Controls.Add(this.manageSubcription);
            this.Name = "NotificationManager";
            this.Text = "NotificationManager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageSubcription;
        private System.Windows.Forms.Button publishNotification;
        private System.Windows.Forms.Button Exit;
    }
}