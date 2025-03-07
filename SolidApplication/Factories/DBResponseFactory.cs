using SolidApplication.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Factories
{
    public static class DBResponseFactory
    {
        public static ResponseBase GetInstance()
        {
            return new ResponseBase();
        }
    }
}
