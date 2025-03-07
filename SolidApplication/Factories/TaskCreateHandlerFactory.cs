using SolidApplication.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Factories
{
    public static class TaskCreateHandlerFactory
    {
        public static TaskCreateHandler GetInstance()
        {
            var db = DbContextFactory.GetIntance();
            var taskRepo = TaskRepositoryFactory.GetInstance(db);

            return new TaskCreateHandler(taskRepo);
        }
    }
}
