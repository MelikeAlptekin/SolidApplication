using SolidApplication.Context;
using SolidApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MyContext _db;

        public UserRepository(MyContext db)
        {
            _db = db;
        }


        public void Add(User item)
        {
            throw new NotImplementedException();
        }

        public User Find(int Id)
        {
            return _db.Users.Find(Id);
        }

        public List<User> GetAll()
        {
            return _db.Users.ToList();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public void Update(User item)
        {
            throw new NotImplementedException();
        }

        public List<User> Where(Expression<Func<User, bool>> expression)
        {
            return _db.Users.Where(expression).ToList();
        }
    }
}
