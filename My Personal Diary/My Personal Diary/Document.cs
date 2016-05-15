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
        public Bitmap image { get; set; }
        public String fileName;
        public bool isChanged;
        public List<Entry> entrys;
        

        public Document()
        {
            fileName = null;
            entrys = new List<Entry>();
            isChanged = true;
            image = null;
        }
        
        #region Entry methods
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

        public Entry findEntry (Entry entry)
        {
            foreach(Entry e in entrys)
            {
                if (e.Date.Equals(entry.Date) && e.ID.Equals(entry.ID))
                    return e;
            }
            return null;
        }
        #endregion
      



    }
}
