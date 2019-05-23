namespace _301025717_TRINH__ASS1
{
    partial class SubcribeForm
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
            this.messageSentByEmail = new System.Windows.Forms.CheckBox();
            this.emailAdress = new System.Windows.Forms.TextBox();
            this.messageSentByMobile = new System.Windows.Forms.CheckBox();
            this.mobileNumber = new System.Windows.Forms.TextBox();
            this.Subcribe = new System.Windows.Forms.Button();
            this.Unscribe = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageSentByEmail
            // 
            this.messageSentByEmail.AutoSize = true;
            this.messageSentByEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageSentByEmail.Location = new System.Drawing.Point(12, 21);
            this.messageSentByEmail.Name = "messageSentByEmail";
            this.messageSentByEmail.Size = new System.Drawing.Size(191, 24);
            this.messageSentByEmail.TabIndex = 0;
            this.messageSentByEmail.Text = "Message sent by Email";
            this.messageSentByEmail.UseVisualStyleBackColor = true;
            // 
            // emailAdress
            // 
            this.emailAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAdress.Location = new System.Drawing.Point(209, 19);
            this.emailAdress.Name = "emailAdress";
            this.emailAdress.Size = new System.Drawing.Size(141, 26);
            this.emailAdress.TabIndex = 1;
            // 
            // messageSentByMobile
            // 
            this.messageSentByMobile.AutoSize = true;
            this.messageSentByMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageSentByMobile.Location = new System.Drawing.Point(12, 61);
            this.messageSentByMobile.Name = "messageSentByMobile";
            this.messageSentByMobile.Size = new System.Drawing.Size(198, 24);
            this.messageSentByMobile.TabIndex = 2;
            this.messageSentByMobile.Text = "Message sent by Mobile";
            this.messageSentByMobile.UseVisualStyleBackColor = true;
            // 
            // mobileNumber
            // 
            this.mobileNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileNumber.Location = new System.Drawing.Point(209, 59);
            this.mobileNumber.Name = "mobileNumber";
            this.mobileNumber.Size = new System.Drawing.Size(140, 26);
            this.mobileNumber.TabIndex = 3;
            // 
            // Subcribe
            // 
            this.Subcribe.Location = new System.Drawing.Point(12, 101);
            this.Subcribe.Name = "Subcribe";
            this.Subcribe.Size = new System.Drawing.Size(93, 28);
            this.Subcribe.TabIndex = 4;
            this.Subcribe.Text = "Subcribe";
            this.Subcribe.UseVisualStyleBackColor = true;
            this.Subcribe.Click += new System.EventHandler(this.Subcribe_Click);
            // 
            // Unscribe
            // 
            this.Unscribe.Location = new System.Drawing.Point(127, 101);
            this.Unscribe.Name = "Unscribe";
            this.Unscribe.Size = new System.Drawing.Size(93, 28);
            this.Unscribe.TabIndex = 5;
            this.Unscribe.Text = "Unscribe";
            this.Unscribe.UseVisualStyleBackColor = false;
            this.Unscribe.Click += new System.EventHandler(this.Unscribe_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(240, 101);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(93, 28);
            this.Close.TabIndex = 6;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // SubcribeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 141);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Unscribe);
            this.Controls.Add(this.Subcribe);
            this.Controls.Add(this.mobileNumber);
            this.Controls.Add(this.messageSentByMobile);
            this.Controls.Add(this.emailAdress);
            this.Controls.Add(this.messageSentByEmail);
            this.Name = "SubcribeForm";
            this.Text = "SubcribeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox messageSentByEmail;
        private System.Windows.Forms.TextBox emailAdress;
        private System.Windows.Forms.CheckBox messageSentByMobile;
        private System.Windows.Forms.TextBox mobileNumber;
        private System.Windows.Forms.Button Subcribe;
        private System.Windows.Forms.Button Unscribe;
        private System.Windows.Forms.Button Close;
    }
}