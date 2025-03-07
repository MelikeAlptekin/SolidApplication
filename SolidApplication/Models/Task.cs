using SolidApplication.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Models
{
    //Task classı bizim için bir entity dir.
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public int? UserId { get; set; } //UserId zorunlu alan değildir.
        public int Hour { get; set; }
        
        public virtual User User { get; set; } //Navigation property

        public Task()
        {

        }


        public Task(string title,string decription, int? userId,int hour)
        {
            this.Title = title.Trim();
            this.Description = decription;
            this.UserId = userId;
            this.Hour = hour;
            this.State = (int)TaskState.Todo;

        }

    }
}
