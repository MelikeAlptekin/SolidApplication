using SolidApplication.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Factories
{
    //Nesne Üretmek için kullanılan sınıflara verilen isimdir.
    public static class DbContextFactory
    {
        public static MyContext GetIntance()
        {
            return new MyContext();
        }
    }
}
