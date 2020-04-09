using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyra.WinUI.UserControlls.Administrator.Track
{
    public partial class ucTrackAdd : UserControl
    {
        private readonly APIService _apiService = new APIService("Track");
        public ucTrackAdd()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            //Todo String -> TimeSpan convertion
            try
            {
                var request = new Model.Requests.TrackUpsertRequest
                {
                    Name = Convert.ToString(txtName.Text)
                };

                await _apiService.Insert<Model.Track>(request);

                MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

            }
        }
    }
}
