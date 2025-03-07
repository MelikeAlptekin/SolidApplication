using SolidApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Commands
{
    public class TaskCreateCommand:ICommand
    {
        private const int MaxWorkHour = 80;
        private const int MinWorkHour = 1;


        public TaskCreateCommand(string title,string description,int? assignedUserId,int estimatedWorkHour=1)
        {
            this.Title = title;
            this.Description = description;
            this.AssignedUserId = assignedUserId;

            if (estimatedWorkHour > MaxWorkHour)
            {
                estimatedWorkHour = MaxWorkHour;
            }
            else if (estimatedWorkHour < MinWorkHour)
            {
                estimatedWorkHour = MinWorkHour;
            }

            this.EstimatedWorkHour = estimatedWorkHour;

        }



        public string Title { get; private set; }
        public string Description { get; private set; }
        public int? AssignedUserId { get; private set; }
        public int EstimatedWorkHour { get; private set; }


    }
}
