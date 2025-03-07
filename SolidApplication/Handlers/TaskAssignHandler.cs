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
    public class TaskAssignHandler : ICommandHandler<TaskAssignCommand, ResponseBase>
    {

        private readonly ITaskRepository _taskRepository;

        public TaskAssignHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public ResponseBase Execute(TaskAssignCommand command)
        {
            var response = DBResponseFactory.GetInstance();
            var task = _taskRepository.Find(command.TaskId);
            task.UserId = command.UserId;

            _taskRepository.Update(task);

            int result = _taskRepository.Save();

            if (result > 0)
            {
                response.IsSucceded = true;
                response.Message = "Task Başarılı Bir Şekilde Atandı";
            }
            else
            {
                response.IsSucceded = false;
                response.Message = "Task Ataması Gerçekleşirken Bir Hata Meydana Geldi";
            }

            return response;
        }
    }
}
