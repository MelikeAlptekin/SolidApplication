using SolidApplication.Events;
using SolidApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Subscribers
{
    public class TaskTodoEventSubscriber : INotification<TaskTodoEvent>
    {

        private IMailService _mailService;
        private ISmsService _smsService;

        public TaskTodoEventSubscriber(IMailService mailService)
        {
            _mailService = mailService;
        }

        //public TaskTodoEventSubscriber(ISmsService smsService)
        //{
        //    _smsService = smsService;
        //}

        //public TaskTodoEventSubscriber(ISmsService smsService,IMailService mailService)
        //{
        //    _smsService = smsService;
        //    _mailService = mailService;
        //}

        public string NotificationMessage { get; set; }

        public void Notify(TaskTodoEvent @event)
        {
            if (_mailService != null && _smsService == null)
            {
                var emailList = new List<String>();
                emailList.Add(@event.TaskAssignedEmailAddress);

                bool result = _mailService.SendMail(
                    subject: @event.MessageTitle,
                    body: @event.Message,
                    to: emailList
                    );

                if (result == true)
                {
                    NotificationMessage = "E-Posta Başarılı Bir Şekilde Gönderildi";
                }
                else
                {
                    NotificationMessage = "E-posta Gönderilemedi";
                }
            }
            else if (_smsService != null && _mailService== null)
            {
                var phoneList = new List<string>();
                phoneList.Add("05556998512");
                phoneList.Add("05486993212");

                bool result = _smsService.SendSms(
                    subject: @event.MessageTitle,
                    body: @event.Message,
                    phoneNumberList: phoneList
                    );

                if (result == true)
                {
                    NotificationMessage = "Sms Başarılı Bir Şekilde Gönderildi";

                }
                else
                {
                    NotificationMessage = "Sms Gönderilemedi";

                }
            }
            else if (_smsService != null && _mailService != null)
            {
                //Önce mail at
                var emailList = new List<String>();
                emailList.Add(@event.TaskAssignedEmailAddress);

                bool mail_result = _mailService.SendMail(
                    subject: @event.MessageTitle,
                    body: @event.Message,
                    to: emailList
                    );

                //sms at
                var phoneList = new List<string>();
                phoneList.Add("05556998512");
                phoneList.Add("05486993212");

                bool sms_result = _smsService.SendSms(
                    subject: @event.MessageTitle,
                    body: @event.Message,
                    phoneNumberList: phoneList
                    );

                if (mail_result == true && sms_result == true)
                {
                    NotificationMessage = "Sms ve Eposta İletildi";
                }
                else
                {
                    NotificationMessage = "Sms ve Eposta İletilmedi!";

                }
            }
        }
    }
}
