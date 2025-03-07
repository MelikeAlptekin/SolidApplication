using SolidApplication.Base;
using SolidApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Commands
{
    public class TaskAssignCommand:TaskAssignBase,ICommand
    {
        public TaskAssignCommand(int taskId,int userId)
        {
            this.TaskId = taskId;
            this.UserId = userId;
        }

        public TaskAssignCommand(int taskId)
        {
            this.TaskId = taskId;
            this.UserId = null;
        }
    }
}
