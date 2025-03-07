using SolidApplication.Base;
using SolidApplication.Commands;
using SolidApplication.Events;
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
    public class TaskTodoHandler : ICommandHandler<TaskTodoCommand, ResponseBase>
    {

        private ITaskRepository _taskRepository;
        private IUserRepository _userRepository;
        private INotification<TaskTodoEvent> _notification;

        public TaskTodoHandler(ITaskRepository taskRepository,IUserRepository userRepository,INotification<TaskTodoEvent> notification)
        {
            _taskRepository = taskRepository;
            _userRepository = userRepository;
            _notification = notification;
        }

        public ResponseBase Execute(TaskTodoCommand command)
        {
            var response = DBResponseFactory.GetInstance();

            var task = _taskRepository.Find(command.TaskId);
            var assigned_user = _userRepository.Find((int)task.UserId);
            task.State = command.State;

           


            try
            {
                _taskRepository.Update(task);
                int result = _taskRepository.Save();

                if (result > 0)
                {
                    response.IsSucceded = true;
                    response.Message = "Task Todo ya Çekildi";

                    if (assigned_user != null )
                    {
                        var @event = new TaskTodoEvent(
                            assignedUserEmail: assigned_user.EmailAddress,
                            taskTitle: task.Title,
                            taskHour: task.Hour,
                            phoneNumber: "05556881245"
                            );

                        _notification.Notify(@event);

                        response.Message = $"Task Todo ya Çekildi \n {_notification.NotificationMessage}";
                        
                    }

                }
                else
                {
                    response.IsSucceded = false;
                    response.Message = "Task Güncellemek için Task State Değiştiriniz";
                }
            }
            catch (Exception)
            {
                response.IsSucceded = false;
                response.Message = "Task Güncellenirken Bir Hata Meydana Geldi";
                throw;
            }


            return response;


        }
    }
}
