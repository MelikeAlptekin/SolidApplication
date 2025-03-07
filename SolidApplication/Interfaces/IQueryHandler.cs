using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Interfaces
{
    //Sorguları bu arayüz üzerinden çalıştırıcaz.
    public interface IQueryHandler<TQuery,TResponse> where TQuery:IQuery where TResponse:class
    {

        TResponse Execute(TQuery query); //Sorguyu çalıştırma methodu.
    }
}
