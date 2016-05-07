using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Personal_Diary
{
    public partial class UserDiary : Form
    {
        string DiaryFile
        {
            get; set;
        }
        string UserName { get; set; }

        public void setDiaryFile(string url, string user)
        { DiaryFile = url; UserName = user; }

        public UserDiary()
        {

           
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = height;
            this.Width = width;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            monthCalendar.TitleBackColor = System.Drawing.Color.Blue;

            fillFontSize();
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e) // Bold funkcija
        {
            Font Bold = new Font(rtEditorDiary.SelectionFont.FontFamily, rtEditorDiary.SelectionFont.SizeInPoints, FontStyle.Bold);
            Font Regular = new Font(rtEditorDiary.SelectionFont.FontFamily, rtEditorDiary.SelectionFont.SizeInPoints, FontStyle.Regular);

            if(rtEditorDiary.SelectionFont.Bold)
            {
                rtEditorDiary.SelectionFont = Regular;
            }
            else
            { rtEditorDiary.SelectionFont = Bold; }
        }

        private void fillFontSize()
        {
            for (int i = 2; i < 73; i += 4)
            {
                ddlSizePick.Items.Add(i);
            }

            ddlSizePick.SelectedIndex = 3;

        }

        public void helloMessage()
        {
            lblHelloMessage.Text = "Hello, " + UserName + "!\nWelcome back.";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
         
        }
    }
}
