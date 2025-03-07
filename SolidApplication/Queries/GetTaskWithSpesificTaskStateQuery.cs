using SolidApplication.Enums;
using SolidApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Queries
{
    //Veri tabanındaki tüm todoları yada tüm done vs. tasklarını getiren query
    public class GetTaskWithSpesificTaskStateQuery:IQuery
    {
        public GetTaskWithSpesificTaskStateQuery(TaskState taskState)
        {
            this.State = (int)taskState;
        }

        public int State { get; private set; }
    }
}
