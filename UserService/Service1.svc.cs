using UserService.Data;

namespace UserService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public User GetUser()
        {
            User user = GetUserTask();
            System.Threading.Thread.Sleep(10000);
            return user;
        }       

        private  User GetUserTask()
        {
            return new User() { Age = "34", LastName = "Rodriguez", Name = "Jorge" };
        }
    }
}
