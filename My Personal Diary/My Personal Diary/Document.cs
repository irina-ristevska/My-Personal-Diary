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


        
    }
}
