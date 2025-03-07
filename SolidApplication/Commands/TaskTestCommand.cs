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
    public class TaskTestCommand:TaskStateBase,ICommand
    {
        public TaskTestCommand(int taskId)
        {
            this.TaskId = taskId;
            this.State = (int)TaskState.Test;
        }
    }
}
