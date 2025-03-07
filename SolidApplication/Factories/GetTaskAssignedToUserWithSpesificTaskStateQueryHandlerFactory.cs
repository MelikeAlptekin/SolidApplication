using SolidApplication.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Factories
{
    public static class GetTaskAssignedToUserWithSpesificTaskStateQueryHandlerFactory
    {
        public static GetTaskAssignedToUserWithSpesificTaskStateQueryHandler GetInstance()
        {
            var db = DbContextFactory.GetIntance();
            var taskRepo = TaskRepositoryFactory.GetInstance(db);

            return new GetTaskAssignedToUserWithSpesificTaskStateQueryHandler(taskRepo);
        }
    }
}
