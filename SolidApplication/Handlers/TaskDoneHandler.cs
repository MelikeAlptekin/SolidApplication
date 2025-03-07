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
    public class TaskDoneHandler : ICommandHandler<TaskDoneCommand, ResponseBase>
    {
        private readonly ITaskRepository _taskRepository;

        public TaskDoneHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public ResponseBase Execute(TaskDoneCommand command)
        {
            var response = DBResponseFactory.GetInstance();

            var task = _taskRepository.Find(command.TaskId);
            task.State = command.State;


            _taskRepository.Update(task);
            int result = _taskRepository.Save();

            if (result > 0)
            {
                response.IsSucceded = true;
                response.Message = "Task State Done Çekildi";
            }
            else
            {
                response.IsSucceded = false;
                response.Message = "Task State Değiştiriken Bir Hata Meydana Geldi";
            }

            return response;
        }
    }
}
