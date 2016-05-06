using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            InitializeComponent();
           
        }

        
    }
}
