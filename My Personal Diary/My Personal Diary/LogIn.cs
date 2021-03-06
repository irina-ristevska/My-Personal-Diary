﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Personal_Diary
{
    public partial class LogIn : Form
    {
        UserBaseController UserBase;
        UserDiary Diary;

        public LogIn()
        {
            UserBase = new UserBaseController();
            Diary = new UserDiary();
            UserBase.LoadXML();
            // Loading XML base (if the file doesnt exist or is corruped the base is created)
           
            InitializeComponent();


        }

        private void pnlUsername_Click(object sender, EventArgs e)
        {
            tbUsername.Focus();
        } //focus on tbUsername if the panel around it is clicked

        private void pnlPassword_Click(object sender, EventArgs e)
        {
            tbPassword.Focus();
        } //focus on tbPassword if the panel around it is clicked

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar!= '\b') && (!(((e.KeyChar >= 'a')&&(e.KeyChar <= 'z'))||((e.KeyChar >= 'A') && (e.KeyChar <= 'Z'))||((e.KeyChar >= '0') && (e.KeyChar <= '9')))))
            {
                e.Handled = true;
            }
        } // Numbers and letters allowed only

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '\b') && (!(((e.KeyChar >= 'a') && (e.KeyChar <= 'z')) || ((e.KeyChar >= 'A') && (e.KeyChar <= 'Z')) || ((e.KeyChar >= '0') && (e.KeyChar <= '9')))))
            {
                e.Handled = true;
            }
            if(e.KeyChar == (char)13)
            {
                LogInFunc();
            }

        } // Numbers and letters allowed only

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            bool isValid = UserBase.SignUpUser(username, password);
            
            if(username == "" || username == "Enter username")
            {
               lblMessage.Text = "Please enter a username";
            }
            else if(password == "" || password == "Password")
            {
               lblMessage.Text = "Please enter a password";
            }
            else if(isValid)
            {


                lblMessage.Text = "Succefully signed up!";
                Diary.saveFile();
                showDiaryDialog();
                                
            }
            else
            {
                lblMessage.Text = "Username already exists";
            }
            pnlMessage.Visible = true;

        } //Create a new user in XML base and load UserDiary

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogInFunc();
        } 

        private void LogInFunc()
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            bool isValid = UserBase.LogInUser(username, password);

            if (username == "")
            {
                lblMessage.Text = "Please enter a username";
            }
            else if (password == "")
            {
                lblMessage.Text = "Please enter a password";
            }
            else if (isValid)
            {
                lblMessage.Text = "Succefully logged in!";
                showDiaryDialog();
            }
            else
            {
                lblMessage.Text = "Invalid username or password";
            }
            pnlMessage.Visible = true;
        } //LogIn with existing user

        private void showDiaryDialog()
        {
            string username = tbUsername.Text;
            string url = UserBase.GetDiaryFile();
            Diary.setDiaryFile(url, username);
            Diary.helloMessage();
            Diary.ShowDialog();
            this.Close();
            
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (tbUsername.Text == "")
                tbUsername.Text = "Enter username";
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbPassword.Text == "")
                tbPassword.Text = "Password";
        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Enter username")
                tbUsername.Text = "";
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
                tbPassword.Text = "";
        }
    }

    
}
