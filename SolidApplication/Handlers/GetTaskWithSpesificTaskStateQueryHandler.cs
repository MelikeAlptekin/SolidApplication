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
    public class GetTaskWithSpesificTaskStateQueryHandler : IQueryHandler<GetTaskWithSpesificTaskStateQuery, List<Models.Task>>
    {
        private readonly ITaskRepository _taskRepository;

        public GetTaskWithSpesificTaskStateQueryHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public List<Models.Task> Execute(GetTaskWithSpesificTaskStateQuery query)
        {
            var tasks = _taskRepository.Where(x => x.State == query.State
            );
            return tasks;
        }
    }
}
