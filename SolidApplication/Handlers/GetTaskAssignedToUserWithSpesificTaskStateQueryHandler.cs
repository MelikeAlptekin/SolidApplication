using SolidApplication.Interfaces;
using SolidApplication.Queries;
using SolidApplication.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Handlers
{
    public class GetTaskAssignedToUserWithSpesificTaskStateQueryHandler : IQueryHandler<GetTaskAssignedToUserWithSpesificTaskStateQuery, List<Models.Task>>
    {

        private readonly ITaskRepository _taskRepository;

        public GetTaskAssignedToUserWithSpesificTaskStateQueryHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public List<Models.Task> Execute(GetTaskAssignedToUserWithSpesificTaskStateQuery query)
        {
            var taskList = _taskRepository.Where(x => x.State == query.State && x.UserId == query.UserId);

            return taskList;
        }
    }
}
