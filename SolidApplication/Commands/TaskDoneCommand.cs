using SolidApplication.Base;
using SolidApplication.Enums;
using SolidApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Commands
{
    public class TaskDoneCommand:TaskStateBase,ICommand
    {
        public TaskDoneCommand(int taskId)
        {
            this.TaskId = taskId;
            this.State = (int)TaskState.Done;
        }
    }
}
