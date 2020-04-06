using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lyra.Model.Requests;

namespace Lyra.WinUI.SingIn
{
    public partial class ucSignIn : UserControl
    {
        private readonly APIService _service = new APIService("User");
        private static ucSignIn _instance;

        public static ucSignIn Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSignIn();
                return _instance;
            }
        }

        public ucSignIn()
        {
            InitializeComponent();
        }

        bool UsernameInDatabase(string username)
        {
            var search = new UserSearchRequest()
            {
                Username = username
            };

            var user = _service.Get<Model.User>(search);

            return user != null ? true : false;
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorUsername.SetError(txtUsername, "Required field");
                e.Cancel = true;
            }
            else if (UsernameInDatabase(txtUsername.Text))
            {
                errorUsername.SetError(txtUsername, "Username does not exist");
                e.Cancel = true;
            }
            else
            {
                errorUsername.SetError(txtUsername, "");
            }


        }
    }
}
