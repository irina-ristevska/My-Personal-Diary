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
        public Color Color { get; set; }
        public bool Bold { get; set; }
        public bool Italic { get; set; }
        public bool Underline { get; set; }
        public Font Font { get; set; }
        public float fontSize { get; set; }
       


        public Entry() { }

        public override string ToString()
        {
            return Title;
        }
    }
}
