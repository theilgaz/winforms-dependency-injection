using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winforms_dependency_injection.Presenters;

namespace winforms_dependency_injection.Views
{
    public interface IUserView
    {
        void JustDoIt(string message);
    }

    public partial class UserView : Form, IUserView
    {
        private UserPresenter _presenter;
        public UserView()
        {
            InitializeComponent();
            _presenter = new UserPresenter(this);
        }

        public void JustDoIt(string message)
        {
            label1.Text = message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = _presenter.GetUserModel();
            MessageBox.Show(user.Name);
        }
    }
}
