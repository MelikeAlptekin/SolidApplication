using SolidApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Factories
{
    public static class NetMailServiceFactory
    {
        public static NetMailService GetInstance()
        {
            return new NetMailService();

        }
    }
}
