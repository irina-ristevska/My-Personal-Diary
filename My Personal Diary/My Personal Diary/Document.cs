using System;
using System.Collections.Generic;
using System.Drawing;
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
    class Document
    {
        public String fileName;
        public bool isChanged;
        public List<Entry> entrys;
       // public List<Reminder> reminders;

        public Document()
        {
            fileName = null;
            entrys = new List<Entry>();
            isChanged = true;
        }

        public void addNewEntry(Entry e)
        {
            entrys.Add(e);
        }

        public void deleteEntry(String title)
        {
            Entry temp = null;
            foreach (Entry e in entrys)
            {
                if (e.Title.Equals(title))
                {
                    temp = e;
                }
            }
            entrys.Remove(temp);
        }

        public void findAndShowEntrysOnThisDate (String date, ListBox list)
        {
            list.Items.Clear();
            foreach (Entry en in entrys)
            {
                if (date == en.Date.ToShortDateString())
                {
                    list.Items.Add(en);
                }
            }
        }
        /*
        public void addNewReminder(Reminder r)
        {
           reminders.Add(r);
        }

        public void deleteReminder(String title)
        {
           Reminder temp = null;
           foreach (Reminder r in reminders)
           {
               if (r.Title.Equals(title))
               {
                   temp = r;
               }
           }
           reminders.Remove(temp);
            }
            */
        
        /// <summary>
        /// add fonts to the ToolStripComboBox
        /// </summary>
        /// <param name="ddlFontPicker"></param>
        public void addFonts (ToolStripComboBox ddlFontPicker)
        {
            foreach (FontFamily fontFamily in FontFamily.Families)
            {
                if (fontFamily.IsStyleAvailable(FontStyle.Regular))
                {
                    ddlFontPicker.Items.Add(fontFamily.Name + " (Regular)");
                }

                if (fontFamily.IsStyleAvailable(FontStyle.Bold))
                {
                    ddlFontPicker.Items.Add(fontFamily.Name + " (Bold)");
                }

                if (fontFamily.IsStyleAvailable(FontStyle.Italic))
                {
                    ddlFontPicker.Items.Add(fontFamily.Name + " (Italic)");
                }

                if (fontFamily.IsStyleAvailable(FontStyle.Underline))
                {
                    ddlFontPicker.Items.Add(fontFamily.Name + " (Underline)");
                }

                if (fontFamily.IsStyleAvailable(FontStyle.Strikeout))
                {
                    ddlFontPicker.Items.Add(fontFamily.Name + " (Strikeout)");
                }
                ddlFontPicker.SelectedIndex = 0;
            }
        }
    }
}
