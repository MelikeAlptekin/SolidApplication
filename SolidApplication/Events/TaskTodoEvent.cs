using SolidApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Events
{
    public class TaskTodoEvent:IEvent
    {
        public string TaskAssignedEmailAddress { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Message { get; private set; }
        public string TaskTitle { get; private set; }
        public string MessageTitle { get; private set; }
        public int TaskHour { get; private set; }

        public TaskTodoEvent(string assignedUserEmail,string taskTitle,int taskHour,string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
            this.TaskAssignedEmailAddress = assignedUserEmail;
            this.TaskTitle = taskTitle;
            this.TaskHour = taskHour;
            this.MessageTitle = $"{taskTitle} Todo' ya Çekildi";
            this.Message = $"Değerli Takım Arkadaşımız ,\n {taskTitle} için uygun görülen süreniz {taskHour} saat olup.Taskınız Todo ya Çekilmiştir.";
        }
    }
}
