using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winforms_dependency_injection.Models;

namespace winforms_dependency_injection.Services
{
    public class UserService : IUserService
    {
        public UserModel GetUser(int Id)
        {
            return new UserModel() { Id = Id, Name = "Anakin Skywalker" };
        }
    }
}
