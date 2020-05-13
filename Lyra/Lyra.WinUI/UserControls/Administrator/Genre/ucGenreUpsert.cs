using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lyra.WinUI.Validators;
using Lyra.WinUI.Helpers;

namespace Lyra.WinUI.UserControls.Administrator.Genre
{
    public partial class ucGenreUpsert : UserControl
    {
        private readonly APIService _apiService = new APIService("Genre");
        private readonly int? _ID;
        public ucGenreUpsert(int? ID = null)
        {
            _ID = ID;
            InitializeComponent();
        }

        private async void ucGenreUpsert_Load(object sender, EventArgs e)
        {
            if(_ID.HasValue)
            {
                var genre = await _apiService.GetById<Model.Genre>(_ID.Value);
                txtName.Text = genre.Name;
            }
        }

        private void Name_Validating(object sender, CancelEventArgs e)
        {
            var validator = new GenreValidator();
            var result = validator.NameCheck(txtName.Text);
            errorProviderName.SetError(txtName, result.Message);
            e.Cancel = !result.IsValid;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                try
                {
                    var request = new Model.Requests.GenreUpsertRequest
                    {
                        Name = Convert.ToString(txtName.Text),
                    };

                    if (_ID.HasValue)
                    {
                        await _apiService.Update<Model.Genre>(_ID.Value, request);
                    }
                    else
                    {
                        await _apiService.Insert<Model.Genre>(request);
                        PanelHelper.SwapPanels(this.Parent, this, new ucGenreUpsert());
                    }

                    MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
