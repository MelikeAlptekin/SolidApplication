using SolidApplication.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        // private MyContext db = new MyContext();

        //Yukarıdaki kullanım Dependency Inversion prensibine aykırıdır.Nedeni ise bir sınıf başka bı sınıfın direk intancesını almamalıdır.Bu prensibe uymaz isek Sınıflar arasında sıkı baglılık oluşur bunun yerine static bır sınıf üzerinden contructora intance göndeririz. Bu yöntemede dependncy Injection denir. Dependency Injection ile projelerimizde bagımlılıkları ortadan kaldırıp daha genişletilebilir projeler yazmayı sağlarız.

        private MyContext _db;

        public TaskRepository(MyContext db)
        {
            _db = db;
        }

        public void Add(Models.Task item)
        {
            _db.Tasks.Add(item);
        }

        public Models.Task Find(int Id)
        {
            return _db.Tasks.Find(Id);
        }

        public List<Models.Task> GetAll()
        {
            return _db.Tasks.ToList();
        }

        public int Save()
        {
            return _db.SaveChanges();
        }

        public void Update(Models.Task item)
        {

            _db.Tasks.Attach(item);//Attach methodu program nesnesini database ile ilişkilendiren methodtur. 
            DbEntityEntry entry = _db.Entry(item); //db deki sundaki kayıt bilgilerini getirir.

            foreach (var propertyName in entry.OriginalValues.PropertyNames)
            {
                var original = entry.GetDatabaseValues().GetValue<object>(propertyName);

                var current = entry.CurrentValues.GetValue<object>(propertyName);

                if (!object.Equals(original,current))
                {
                    entry.Property(propertyName).IsModified = true;
                }
            }
        }

        public List<Models.Task> Where(Expression<Func<Models.Task, bool>> expression)
        {
            return _db.Tasks.Where(expression).ToList();
        }
    }
}
