using SolidApplication.Context;
using SolidApplication.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Factories
{
    public static class TaskRepositoryFactory
    {
        public static TaskRepository GetInstance(MyContext db)
        {
            return new TaskRepository(db);
        }
    }
}
