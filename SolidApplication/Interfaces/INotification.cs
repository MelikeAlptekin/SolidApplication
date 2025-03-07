using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Interfaces
{
    public interface INotification<T> where T:IEvent
    {
        string NotificationMessage { get; set; }
        void Notify(T @event);
    }
}
