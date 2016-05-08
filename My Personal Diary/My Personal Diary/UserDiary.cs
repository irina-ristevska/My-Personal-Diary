using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Personal_Diary
{
    [Serializable]
    public partial class UserDiary : Form
    {
        Document doc;

        string DiaryFile
        {
            get; set;
        }
        string UserName { get; set; }
        public bool isChanged { get; private set; }
        public string fileName { get; private set; }

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
            lblPickDateListBox.Text = monthCalendar.SelectionStart.ToShortDateString();
            doc = new Document();
            doc.addFonts(ddlFontPicker);
            this.rtEditorDiary.ForeColor = cdColor.Color;
            fileName = null;
        }

        private void toolStripButton1_Click(object sender, EventArgs e) // Bold funkcija
        {
            Font Bold = new Font(rtEditorDiary.SelectionFont.FontFamily, rtEditorDiary.SelectionFont.SizeInPoints, rtEditorDiary.Font.Style | FontStyle.Bold);
            Font Regular = new Font(rtEditorDiary.SelectionFont.FontFamily, rtEditorDiary.SelectionFont.SizeInPoints, rtEditorDiary.Font.Style | FontStyle.Regular);

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
            fileName = null;
            saveFile();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            Entry en = new Entry();
            en.Title = tbTitle.Text.ToString();
            en.Text = rtEditorDiary.Text.ToString();
            en.Bold = tsBold.Enabled;
            en.Italic = tsItalic.Enabled;
            en.Underline = tsUnderline.Enabled;
            en.Date = monthCalendar.SelectionStart;
            en.StringDate = monthCalendar.SelectionStart.ToShortDateString();

            doc.addNewEntry(en);
            clearFields();
            lbThisDateEntries.Items.Add(en);
        }

        private void clearFields()
        {
            tbTitle.Text = "Diary Title";
            rtEditorDiary.Text = "";
            cdColor.Color = Color.Blue;
            rtEditorDiary.Font = new Font(rtEditorDiary.SelectionFont.FontFamily, rtEditorDiary.SelectionFont.SizeInPoints, rtEditorDiary.Font.Style | FontStyle.Regular);

        }
        private void tsItalic_Click(object sender, EventArgs e)
        {
            Font Italic = new Font(rtEditorDiary.SelectionFont.FontFamily, rtEditorDiary.SelectionFont.SizeInPoints, rtEditorDiary.Font.Style | FontStyle.Italic);
            Font Regular = new Font(rtEditorDiary.SelectionFont.FontFamily, rtEditorDiary.SelectionFont.SizeInPoints, rtEditorDiary.Font.Style | FontStyle.Regular);

            if (rtEditorDiary.SelectionFont.Italic)
            {
                rtEditorDiary.SelectionFont = Regular;
            }
            else
            {
                rtEditorDiary.SelectionFont = Italic;
            }
        }

        private void tsUnderline_Click(object sender, EventArgs e)
        {
            Font Underline = new Font(rtEditorDiary.SelectionFont.FontFamily, rtEditorDiary.SelectionFont.SizeInPoints, rtEditorDiary.Font.Style | FontStyle.Underline);
            Font Regular = new Font(rtEditorDiary.SelectionFont.FontFamily, rtEditorDiary.SelectionFont.SizeInPoints, rtEditorDiary.Font.Style | FontStyle.Regular);

            if (rtEditorDiary.SelectionFont.Underline)
            {
                rtEditorDiary.SelectionFont = Regular;
            }
            else
            {
                rtEditorDiary.SelectionFont = Underline;
            }
        }

        private void tbTitle_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text.ToString() == "Diary Title")
                tbTitle.Text = "";
        }

        private void tbTitle_Validating(object sender, CancelEventArgs e)
        {
            if (tbTitle.Text == "")
                tbTitle.Text = "Diary Title";
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            lblDateNewEntry.Text = e.Start.ToShortDateString();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblDateNewEntry.Text = e.Start.ToShortDateString();
            lblPickDateListBox.Text = e.Start.ToShortDateString();

            doc.findAndShowEntrysOnThisDate(lblPickDateListBox.Text, lbThisDateEntries);
        }

        private void ddlFontPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///does not work
            String familyName = ddlFontPicker.SelectedItem.ToString();
            Font f = new Font(familyName, 14);
            rtEditorDiary.SelectionFont = f;
        }

        private void ddlSizePick_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change the font size
        }

        private void tsbFontColor_Click(object sender, EventArgs e)
        {
            cdColor.ShowDialog();
            this.rtEditorDiary.SelectionColor = cdColor.Color;

        }

        private void tsbFontColor_EnabledChanged(object sender, EventArgs e)
        {
            this.rtEditorDiary.ForeColor = cdColor.Color;
        }

        /// <summary>
        /// Save the document
        /// </summary>
        public void saveFile()
        {
            if (fileName == null)
            {
                fileName = UserName;
            }
            if (fileName != null)
            {
                IFormatter fmt = new BinaryFormatter();
                FileStream strm = new FileStream(fileName,
                    FileMode.Create, FileAccess.Write, FileShare.None);
                fmt.Serialize(strm, doc);
                strm.Close();
                isChanged = false;
            }
        }

        /// <summary>
        /// Opening file
        /// </summary>
        /// <param name="filename"></param>
        public void openFile(string filename)
        {
            try
            {
                fileName = filename;
                IFormatter fmt = new BinaryFormatter();
                FileStream strm = new FileStream(fileName, FileMode.Open,
                    FileAccess.Read, FileShare.None);
                doc = (Document)fmt.Deserialize(strm);
                strm.Close();
                MessageBox.Show("Uspesno otvoreno :D");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Cold not read file \"" + filename +
                    "\" from disk. Original error: " + ex.Message);
                fileName = null;
            }
            if (fileName != null)
                isChanged = false;
        }

        private void UserDiary_Load(object sender, EventArgs e)
        {
            openFile(UserName);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LogIn l = new LogIn();
            l.Show();
        }
        /// <summary>
        /// ...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbThisDateEntries_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Entry en = (Entry)lbThisDateEntries.SelectedItem;
                tbTitle.Text = en.Title;
                rtEditorDiary.Text = en.Text;
                rtEditorDiary.Font = en.Font;
                rtEditorDiary.ForeColor = en.Color;
            }
            catch (Exception ex)
            { }
        }
    }
}
