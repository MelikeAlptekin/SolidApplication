using SolidApplication.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Factories
{
    public static class TaskTodoHandlerFactory
    {
        public static TaskTodoHandler GetInstance()
        {
            var db = DbContextFactory.GetIntance();
            var taskRepo = TaskRepositoryFactory.GetInstance(db);
            var userRepo = UserRepositoryFactory.GetInstance(db);
            var notification = TaskEventSubscriberFactory.GetInstance();
          

            return new TaskTodoHandler(taskRepo,userRepo,notification);
        }
    }
}
