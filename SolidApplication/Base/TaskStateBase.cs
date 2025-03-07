using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Base
{
    public abstract class TaskStateBase
    {
        public int TaskId { get; set; } //State yani durumu değişicek olan TaskId
        public int State { get; set; } //Taskın değişicek olan durumu.
    }
}
