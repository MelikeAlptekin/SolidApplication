using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Base
{
    public abstract class TaskAssignBase
    {
        public int TaskId { get; protected set; } //Protected kalıtım alan sınıflarda set edilebilir.Access Modifierı.
        public int? UserId { get; protected set; }
    }
}
