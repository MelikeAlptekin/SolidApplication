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
    public class TaskInProgressHandler : ICommandHandler<TaskInProgressCommand, ResponseBase>
    {
        private readonly ITaskRepository _taskRespository;

        public TaskInProgressHandler(ITaskRepository taskRepository)
        {
            _taskRespository = taskRepository;
        }

        public ResponseBase Execute(TaskInProgressCommand command)
        {
            var response = DBResponseFactory.GetInstance();

            var task = _taskRespository.Find(command.TaskId);

            task.State = command.State;

            _taskRespository.Update(task);

            int result = _taskRespository.Save();

            if (result > 0)
            {
                response.IsSucceded = true;
                response.Message = "Task InProgress'e Çekildi";
            }
            else
            {
                response.IsSucceded = false;
                response.Message = "Task State Değiştirirken Bir Hata Meydana Geldi";
            }

            return response;
        }
    }
}
