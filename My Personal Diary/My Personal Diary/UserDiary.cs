﻿using System;
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
        private bool editing;
        private bool isSaved;

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
            doc = new Document();
            
            editing = false;
            isSaved = true;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = height;
            this.Width = width;
            this.WindowState = FormWindowState.Maximized;

            InitializeComponent();
            
            fillFontSize();
            lblPickDateListBox.Text = monthCalendar.SelectionStart.ToShortDateString();
            
            fillFontFamily();
            this.rtEditorDiary.ForeColor = Color.Salmon;
            fileName = null;

            lblDateNewEntry.Text = monthCalendar.TodayDate.ToShortDateString();
            doc.findAndShowEntrysOnThisDate(monthCalendar.TodayDate.ToShortDateString(), lbThisDateEntries);
            doc.findAndShowAllTasks(lbTasks);
            hideComponents();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parms = base.CreateParams;
                parms.ClassStyle |= 0x200;
                return parms;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e) // Bold funkcija
        {
            Font Bold = new Font(rtEditorDiary.SelectionFont.FontFamily, rtEditorDiary.SelectionFont.SizeInPoints, rtEditorDiary.Font.Style | FontStyle.Bold);
            Font Regular = new Font(rtEditorDiary.SelectionFont.FontFamily, rtEditorDiary.SelectionFont.SizeInPoints, rtEditorDiary.Font.Style | FontStyle.Regular);

            if (rtEditorDiary.SelectionFont.Bold)
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
           saveFile();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            toggleEntryEditor();
            clearFields();
            enableEditor();
            showComponents();
            isSaved = false;
            editing = false;
        }

        private void clearFields()
        {
            tbTitle.Text = "Diary Title";
            rtEditorDiary.Text = "";
            cdColor.Color = Color.Yellow;
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

        private void fillFontFamily()
        {
            foreach (FontFamily fontFamily in FontFamily.Families)
            {
                ddlFontPicker.Items.Add(fontFamily.Name.ToString());
                ddlFontPicker.SelectedIndex = 0;
            }
        }

        private void ddlFontPicker_SelectedIndexChanged(object sender, EventArgs e) // fixed
        {
            String familyName = ddlFontPicker.SelectedItem.ToString();
            FontFamily ff = new FontFamily(familyName);
            Font f = new Font(ff, rtEditorDiary.SelectionFont.Size, rtEditorDiary.SelectionFont.Style);
            rtEditorDiary.SelectionFont = f;
        }

        private void ddlSizePick_SelectedIndexChanged(object sender, EventArgs e)
        {
            float size = rtEditorDiary.SelectionFont.SizeInPoints;
            float newSize = 14;
            float.TryParse(ddlSizePick.SelectedItem.ToString(), out newSize);
            Font newFont = new Font(rtEditorDiary.SelectionFont.Name, newSize, rtEditorDiary.SelectionFont.Style);
            rtEditorDiary.SelectionFont = newFont;
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
               // MessageBox.Show("Uspesno otvoreno");
            }
            catch (Exception ex)
            {
                saveFile();
                openFile(filename);
            }
            if (fileName != null)
                isChanged = false;
        }

        private void UserDiary_Load(object sender, EventArgs e)
        {
            
            pnlTaskEditor.Visible = false;
            freezeEditor();
            openFile(UserName);
            doc.findAndShowEntrysOnThisDate(monthCalendar.TodayDate.ToShortDateString(), lbThisDateEntries);
            if(doc.image!=null)
                pbUserIcon.Image = doc.image;
           
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (!isSaved)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save your changes?",
                "Log out", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    saveFile();
            }
            this.Close();    
            LogIn l = new LogIn();
            l.Show();
        }

        private void tsbFontHighLighter_Click(object sender, EventArgs e)
        {
            cdColor.ShowDialog();
            this.rtEditorDiary.SelectionBackColor = cdColor.Color;
        }

        private void pbUserIcon_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbUserIcon_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    PictureBox PictureBox1 = new PictureBox();

                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    pbUserIcon.Image = new Bitmap(dlg.FileName);
                    doc.image = new Bitmap(dlg.FileName);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Entry en;
            if (tbTitle.Text == "Diary Title")
            {
                MessageBox.Show("Enter Title");
                return;
            }
            if (editing)
            {
                en = doc.findEntry((Entry)lbThisDateEntries.SelectedItem);
                en.setEntry(tbTitle.Text.ToString(), monthCalendar.SelectionStart.ToShortDateString(), rtEditorDiary.Rtf, monthCalendar.SelectionStart);//changed

            }
            else
            {
                en = new Entry();
                en.setEntry(tbTitle.Text.ToString(), monthCalendar.SelectionStart.ToShortDateString(), rtEditorDiary.Rtf, monthCalendar.SelectionStart);//changed

                List<Entry> lst = doc.entrys;
                doc.addNewEntry(en);
                lst = doc.entrys;
                lbThisDateEntries.Items.Add(en);
            }
            clearFields();
            freezeEditor();
            hideComponents();
            isSaved = false;
        }

        private void btDeleteE_Click(object sender, EventArgs e)
        {
            try
            {
                Entry en = (Entry)lbThisDateEntries.SelectedItem;
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected entry?",
                "Deleting", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    lbThisDateEntries.Items.RemoveAt(lbThisDateEntries.SelectedIndex);
                    doc.deleteEntry(en.Title);
                    clearFields();
                }
                isSaved = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Select the entry for deleting !");
            }
        }

        private void btEditE_Click(object sender, EventArgs e)
        {
            Entry en = (Entry)lbThisDateEntries.SelectedItem;

        }


        private void freezeEditor()
        {
            btnClose.Enabled = false;
            rtEditorDiary.Enabled = false;
            tbTitle.Enabled = false;

        }

        private void enableEditor()
        {
            btnClose.Enabled = true;
            rtEditorDiary.Enabled = true;
            tbTitle.Enabled = true;
        }

        private void hideComponents()
        {
            btnClose.Enabled = false;
            rtEditorDiary.Visible = false;
            tbTitle.Visible = false;
        }

        private void showComponents()
        {
            btnClose.Enabled = true;
            rtEditorDiary.Visible = true;
            tbTitle.Visible = true;
        }

        private void lbThisDateEntries_SelectedValueChanged(object sender, EventArgs e)
        {
            showComponents();
            freezeEditor();
            try
            {
                Entry en = (Entry)lbThisDateEntries.SelectedItem;
                tbTitle.Text = en.Title;
                rtEditorDiary.Rtf = en.Text;
                freezeEditor();
            }
            catch (Exception ex)
            { }
        }

        private void btEditEntry_Click(object sender, EventArgs e)
        {
            toggleEntryEditor();
            showComponents();
            enableEditor();
            editing = true;
            isSaved = false;
        }

        private void lbThisDateEntries_SelectedIndexChanged(object sender, EventArgs e)
        {

            toggleEntryEditor();    
            showComponents();
            freezeEditor();
            try
            {
                Entry en = (Entry)lbThisDateEntries.SelectedItem;
                tbTitle.Text = en.Title;
                rtEditorDiary.Rtf = en.Text;
                freezeEditor();
            }
            catch (Exception ex)
            { }
        }

        private void lbTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            toggleTaskEditor();
        }

        private void btnReminder_Click(object sender, EventArgs e)
        {
            toggleTaskEditor();
        }

        private void toggleTaskEditor()
        {
            lbThisDateEntries.SelectedIndex = -1;
            pnlDiaryEntryEditor.Visible = false;
            pnlTaskEditor.Visible = true;
        }
        private void toggleEntryEditor()
        {
            lbTasks.SelectedIndex = -1;
            pnlDiaryEntryEditor.Visible = true;
            pnlTaskEditor.Visible = false;
        }

        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            Task t;
            if (tbTaskTitle.Text == "Task Title")
            {
                MessageBox.Show("Enter Title");
                return;
            }
            if (editing)
            {
                t = doc.findTask((Task)lbTasks.SelectedItem);
                t.setTask(tbTaskTitle.Text + monthCalendar.SelectionStart.ToShortDateString(), rtTaskDetail.Rtf, monthCalendar.SelectionStart);

            }
            else
            {
                t = new Task();
                t.setTask(tbTaskTitle.Text + monthCalendar.SelectionStart.ToShortDateString(), rtTaskDetail.Rtf, monthCalendar.SelectionStart);
                List<Task> tsk = doc.Tasks;
                string details = t.Title;
                string due = t.DueDate.ToShortDateString();
                int aa = t.ID;
                if (t != null)
                {
                    doc.Tasks.Add(t);
                    lbTasks.Items.Add(t);
                }
            }
            clearFields();
            freezeEditor();
            hideComponents();
            isSaved = false;
        }
    }

   
}
