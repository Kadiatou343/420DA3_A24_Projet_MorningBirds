using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAdvancedMultiTier.Business.Abstractions;
public interface IServiceContainer : IExceptionHandler {

    public T GetService<T>() where T : class, IService;

    public void RegisterService(IService service);

}
