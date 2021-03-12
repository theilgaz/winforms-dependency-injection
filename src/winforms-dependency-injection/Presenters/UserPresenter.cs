using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winforms_dependency_injection.Models;
using winforms_dependency_injection.Services;
using winforms_dependency_injection.Views;

namespace winforms_dependency_injection.Presenters
{
    public class UserPresenter
    {
        private readonly IUserView _view;
        private IUserService userService;
        public UserPresenter(IUserView view)
        {
            _view = view;
            userService = Program.GetService<IUserService>(); // request service object from ServiceProvider

            JustDoIt(); // quick sample for calling method from presenter
        }

        public void JustDoIt()
        {
            _view.JustDoIt("Hello User!");
        }

        public UserModel GetUserModel()
        {
            return userService.GetUser(1); // calling method from ui
        }
    }
}
