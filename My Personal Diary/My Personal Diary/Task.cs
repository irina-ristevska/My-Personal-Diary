using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Personal_Diary
{
    [Serializable]
    class Task
    {
        public string Title { set; get; }
        public string Detail { set; get; }
        public DateTime DueDate { set; get; }
        public int Progress { set; get; }
        public bool isComplete { get; set; }
        public int ID { get; private set; }

        public Task()
        {
            Title = "";
            Detail = "";
            DueDate = new DateTime();
            isComplete = false;
            Progress = 0;
            ID = new Random().Next();
        }

        public void setTask(string title, string detail, DateTime due)
        {
            Title = title;
            Detail = detail;
            DueDate = due;
        }

        public void changeProgress(int number)
        {
            Progress = number;
            if (number == 100)
            {
                isComplete = true;
            }
        }


    }
}
