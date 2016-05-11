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
        public List<Task> Tasks;

        public Document()
        {
            fileName = null;
            entrys = new List<Entry>();
            Tasks = new List<Task>();
            Tasks.Add(new Task());
            isChanged = true;
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
        #region Task methods
        public void addNewTask(Task t)
        {
            Tasks.Add(new Task());
            Tasks.Add(t);
        }
        public void findAndShowTasksDueThisDate(String date, ListBox list)
        {
            list.Items.Clear();
            foreach (Task t in Tasks)
            {
                if (date == t.DueDate.ToShortDateString())
                {
                    list.Items.Add(t);
                }
            }
        }

        public void findAndShowAllTasks(ListBox list)
        {
            list.Items.Clear();
            foreach (Task t in Tasks)
            {
                 list.Items.Add(t);
                
            }
        }

        public Task findTask(Task task)
        {
            foreach (Task t in Tasks)
            {
                if (t.DueDate.Equals(task.DueDate) && t.ID.Equals(task.ID))
                    return t;
            }
            return null;
        }


        #endregion



    }
}
