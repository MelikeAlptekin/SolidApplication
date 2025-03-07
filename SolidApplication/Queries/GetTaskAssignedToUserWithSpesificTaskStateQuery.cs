using SolidApplication.Enums;
using SolidApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Queries
{
    //Usera atanmış spesific taskları getiren query
    //Mecnunun todo taskları. 
    public class GetTaskAssignedToUserWithSpesificTaskStateQuery:IQuery
    {

        public GetTaskAssignedToUserWithSpesificTaskStateQuery(int userId,
            TaskState taskState)
        {
            this.UserId = userId;
            this.State = (int)taskState;
        }

        public int UserId { get; private set; }
        public int State { get; private set; }
    }
}
