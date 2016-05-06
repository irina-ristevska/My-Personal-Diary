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
            UserBase.LoadXML(); // loadiranje na bazata so korisnici (dokolku ne postoi fajlot, se kreira)
            InitializeComponent();


        }

        private void pnlUsername_Click(object sender, EventArgs e)
        {
            tbUsername.Focus();
        }

        private void pnlPassword_Click(object sender, EventArgs e)
        {
            tbPassword.Focus();
        }

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar!= '\b') && (!(((e.KeyChar >= 'a')&&(e.KeyChar <= 'z'))||((e.KeyChar >= 'A') && (e.KeyChar <= 'Z'))||((e.KeyChar >= '0') && (e.KeyChar <= '9')))))
            {
                e.Handled = true;
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '\b') && (!(((e.KeyChar >= 'a') && (e.KeyChar <= 'z')) || ((e.KeyChar >= 'A') && (e.KeyChar <= 'Z')) || ((e.KeyChar >= '0') && (e.KeyChar <= '9')))))
            {
                e.Handled = true;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            bool isValid = UserBase.SignUpUser(username, password);
            
            if(username == "")
            {
               lblMessage.Text = "Please enter a username";
            }
            else if(password == "")
            {
               lblMessage.Text = "Please enter a password";
            }
            else if(isValid)
            {
               
                lblMessage.Text = "Succefully signed up!";
                showDiaryDialog();
                                
            }
            else
            {
                lblMessage.Text = "Username already exists";
            }
            pnlMessage.Visible = true;

        }

        private void btnLogIn_Click(object sender, EventArgs e)
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
        }

        private void showDiaryDialog()
        {
            string username = tbUsername.Text;
            string url = UserBase.GetDiaryFile();
            this.Hide();
            Diary.setDiaryFile(url, username);
            Diary.ShowDialog();
        }
       
    }

    
}
