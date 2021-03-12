using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winforms_dependency_injection.Models;

namespace winforms_dependency_injection.Services
{
    public interface IUserService
    {
        UserModel GetUser(int Id);
    }
}
