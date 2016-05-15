using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Personal_Diary
{
    [Serializable]
    class Entry
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public String Text { get; set; }
        public int ID { get; private set; }

        public void setEntry(string title,  string txt, DateTime time)
        {
            Title = title;
            Text = txt;
            Date = time;
        }

        public Entry()
        {
            ID = new Random().Next();
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
