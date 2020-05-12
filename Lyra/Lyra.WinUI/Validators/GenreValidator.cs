using Lyra.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyra.WinUI.Validators
{
    public class GenreValidator : BaseValidator, IGenreValidator
    {
        private readonly APIService _apiService = new APIService("Genre");
        public async Task<ValidationResult> NameCheck(string value)
        {
            var request = new GenreSearchRequest()
            {
                Name = value
            };

            var response = await _apiService.Get<List<Model.User>>(request);

            if (!Required(value))
            {
                return new ValidationResult("This is a required field", false);
            }
            else if (response.Count == 1)
            {
                return new ValidationResult("Genre already exists", false);
            }
            else
            {
                return new ValidationResult("", true);
            }
        }
    }
}
