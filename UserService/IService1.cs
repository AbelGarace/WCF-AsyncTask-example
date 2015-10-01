using System.ServiceModel;
using System.Threading.Tasks;
using UserService.Data;

namespace UserService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        User GetUser();
      
    }  
}
