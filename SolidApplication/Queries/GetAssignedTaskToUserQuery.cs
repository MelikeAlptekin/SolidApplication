using SolidApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Queries
{
    //Sadece kişiye özgü taskları getiren Query
    public class GetAssignedTaskToUserQuery:IQuery
    {
        public GetAssignedTaskToUserQuery(int userId)
        {
            this.UserId = userId;
        }

        public int UserId { get; private set; }
    }
}
