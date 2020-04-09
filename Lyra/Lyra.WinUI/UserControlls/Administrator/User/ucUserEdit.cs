using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyra.WinUI.UserControlls.Administrator.User
{
    public partial class ucUserEdit : UserControl
    {
        public ucUserEdit()
        {
            InitializeComponent();
        }

        public ucUserEdit(Model.User user)
        {
            InitializeComponent();

            txtID.Text = Convert.ToString(user.ID);
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtUsername.Text = user.Username;
            txtEmail.Text = user.Email;
            txtPhoneNumber.Text = user.PhoneNumber;
        }
    }
}
