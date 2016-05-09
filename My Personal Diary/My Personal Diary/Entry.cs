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
        public String StringDate { get; set; }
        public String Text { get; set; }

       


        public Entry() { }

        public override string ToString()
        {
            return Title;
        }
    }
}
