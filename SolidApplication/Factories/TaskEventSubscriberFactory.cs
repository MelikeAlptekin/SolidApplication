using SolidApplication.Subscribers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Factories
{
    public static class TaskEventSubscriberFactory
    {
        public static TaskTodoEventSubscriber GetInstance()
        {
            var mailService = NetMailServiceFactory.GetInstance();
            //var smsService = TurkcellSmsServiceFactory.GetInstance();

            return new TaskTodoEventSubscriber(mailService);

        }
    }
}
