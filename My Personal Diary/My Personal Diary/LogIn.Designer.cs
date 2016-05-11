namespace My_Personal_Diary
{
    partial class LogIn
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
            this.pnlBox = new System.Windows.Forms.Panel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPassIcon = new System.Windows.Forms.PictureBox();
            this.pbUserIcon = new System.Windows.Forms.PictureBox();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pnlMessage = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).BeginInit();
            this.pnlUsername.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.pnlMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBox
            // 
            this.pnlBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.pnlBox.Controls.Add(this.btnSignUp);
            this.pnlBox.Controls.Add(this.btnLogIn);
            this.pnlBox.Controls.Add(this.label1);
            this.pnlBox.Controls.Add(this.pbPassIcon);
            this.pnlBox.Controls.Add(this.pbUserIcon);
            this.pnlBox.Controls.Add(this.pnlUsername);
            this.pnlBox.Controls.Add(this.pnlPassword);
            this.pnlBox.Location = new System.Drawing.Point(73, 194);
            this.pnlBox.Name = "pnlBox";
            this.pnlBox.Size = new System.Drawing.Size(340, 382);
            this.pnlBox.TabIndex = 0;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(97)))), ((int)(((byte)(113)))));
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(15, 324);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(310, 46);
            this.btnSignUp.TabIndex = 7;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(97)))), ((int)(((byte)(113)))));
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogIn.Location = new System.Drawing.Point(15, 269);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(310, 46);
            this.btnLogIn.TabIndex = 6;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BurlyWood;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter your Diary account";
            // 
            // pbPassIcon
            // 
            this.pbPassIcon.BackgroundImage = global::My_Personal_Diary.Properties.Resources.Pass_Icon;
            this.pbPassIcon.Location = new System.Drawing.Point(15, 181);
            this.pbPassIcon.Name = "pbPassIcon";
            this.pbPassIcon.Size = new System.Drawing.Size(60, 60);
            this.pbPassIcon.TabIndex = 4;
            this.pbPassIcon.TabStop = false;
            // 
            // pbUserIcon
            // 
            this.pbUserIcon.BackgroundImage = global::My_Personal_Diary.Properties.Resources.User_Icon;
            this.pbUserIcon.Location = new System.Drawing.Point(15, 95);
            this.pbUserIcon.Name = "pbUserIcon";
            this.pbUserIcon.Size = new System.Drawing.Size(60, 60);
            this.pbUserIcon.TabIndex = 3;
            this.pbUserIcon.TabStop = false;
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlUsername.Controls.Add(this.tbUsername);
            this.pnlUsername.Location = new System.Drawing.Point(75, 95);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(250, 60);
            this.pnlUsername.TabIndex = 1;
            this.pnlUsername.Click += new System.EventHandler(this.pnlUsername_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbUsername.Location = new System.Drawing.Point(16, 19);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(5);
            this.tbUsername.MaxLength = 10;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(229, 23);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.Text = "Enter username";
            this.tbUsername.Enter += new System.EventHandler(this.tbUsername_Enter);
            this.tbUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUsername_KeyPress);
            this.tbUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tbUsername_Validating);
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlPassword.Controls.Add(this.tbPassword);
            this.pnlPassword.Location = new System.Drawing.Point(75, 181);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(250, 60);
            this.pnlPassword.TabIndex = 2;
            this.pnlPassword.Click += new System.EventHandler(this.pnlPassword_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbPassword.Location = new System.Drawing.Point(16, 19);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(5);
            this.tbPassword.MaxLength = 10;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(229, 23);
            this.tbPassword.TabIndex = 0;
            this.tbPassword.Text = "Password";
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPassword_KeyPress);
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // pnlMessage
            // 
            this.pnlMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMessage.BackColor = System.Drawing.Color.Firebrick;
            this.pnlMessage.Controls.Add(this.lblMessage);
            this.pnlMessage.Location = new System.Drawing.Point(73, 163);
            this.pnlMessage.Name = "pnlMessage";
            this.pnlMessage.Size = new System.Drawing.Size(340, 31);
            this.pnlMessage.TabIndex = 2;
            this.pnlMessage.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMessage.Location = new System.Drawing.Point(5, 6);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(84, 17);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Invisible text";
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogo.BackgroundImage = global::My_Personal_Diary.Properties.Resources.LogoWhite;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbLogo.Location = new System.Drawing.Point(73, 27);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(340, 130);
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(94, 587);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "-- VP Project by Irina Ristevska and Maja Milosheska 2016 --";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(116)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(484, 612);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlMessage);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pnlBox);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.pnlBox.ResumeLayout(false);
            this.pnlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).EndInit();
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.pnlMessage.ResumeLayout(false);
            this.pnlMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBox;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.PictureBox pbPassIcon;
        private System.Windows.Forms.PictureBox pbUserIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label label2;
    }
}

