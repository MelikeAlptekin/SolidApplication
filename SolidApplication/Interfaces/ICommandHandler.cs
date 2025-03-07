using SolidApplication.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApplication.Interfaces
{
    //Create,insert,delete işlemlerini işlicek.
    public interface ICommandHandler<TCommand,TResponse> where TCommand:ICommand where TResponse:ResponseBase
    {
        //Komutu gerçekleştirme methodu ICommanHandler komut işleyici interfacesi bu işlemi gerçekleştirir.
        TResponse Execute(TCommand command);
    }
}
