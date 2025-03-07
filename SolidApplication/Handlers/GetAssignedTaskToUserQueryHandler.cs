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
    public class GetAssignedTaskToUserQueryHandler :IQueryHandler<GetAssignedTaskToUserQuery, List<Models.Task>>
    {

        private readonly ITaskRepository _taskRepository;

        public GetAssignedTaskToUserQueryHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public List<Models.Task> Execute(GetAssignedTaskToUserQuery query)
        {

            var tasks = _taskRepository.Where(x => x.UserId == query.UserId);
            return tasks;
        }
    }
}
