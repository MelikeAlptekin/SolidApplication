using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Models
{
    
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string EmailAddress { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }//Task ve User entityleri arasında bire çok bir ilişki mevcut.Bir kullanıcının birden fazla görevi olabilir.

        public override string ToString()
        {
            return Name + " " + SurName;
        }

    }
}
