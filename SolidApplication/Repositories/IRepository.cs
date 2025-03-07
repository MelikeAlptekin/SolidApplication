using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Repositories
{
    public interface IRepository<T> where T:class
    {
        void Add(T item);
        List<T> GetAll();
        List<T> Where(Expression<Func<T, bool>> expression);
        void Update(T item);
        int Save();
        T Find(int Id);
    }
}
