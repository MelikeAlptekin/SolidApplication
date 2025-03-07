using SolidApplication.Base;
using SolidApplication.Commands;
using SolidApplication.Factories;
using SolidApplication.Interfaces;
using SolidApplication.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Handlers
{
    public class TaskCreateHandler : ICommandHandler<TaskCreateCommand, ResponseBase>
    {
        private readonly ITaskRepository _taskRepository;

        public TaskCreateHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }



        public ResponseBase Execute(TaskCreateCommand command)
        {
            var response = DBResponseFactory.GetInstance();

            var new_task = new Models.Task(
                command.Title,
                command.Description,
                command.AssignedUserId,
                command.EstimatedWorkHour
                );

            _taskRepository.Add(new_task);
            int result = _taskRepository.Save();

            if (result > 0)
            {
                response.IsSucceded = true;
                response.Message = "Yeni Bir Task Oluştu";

            }
            else
            {
                response.IsSucceded = false;
                response.Message = "Task Oluşurken Bir Hata Meydana Geldi.";
            }


            return response;
        }
    }
}
