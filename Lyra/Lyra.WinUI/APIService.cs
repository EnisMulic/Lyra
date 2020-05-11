using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl;
using Lyra.Model;
using System.Windows.Forms;
using Lyra.Model.Requests;

namespace Lyra.WinUI
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }

        private readonly string _route;

        public APIService(string route)
        {
            _route = route;
        }

        public async Task<Model.User> Authenticate(UserAuthenticationRequest request)
        {
            try
            {
                var url = $"{Properties.Settings.Default.APIUrl}/User/Auth";
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<User>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(Model.User);
            }
        }

        public async Task<Model.User> SignUp(UserInsertRequest request)
        {
            try
            {
                var url = $"{Properties.Settings.Default.APIUrl}/User/SignUp";
                return await url.PostJsonAsync(request).ReceiveJson<User>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(Model.User);
            }
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            if(search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            try
            {
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }

        }

        public async Task<T> Update<T>(int id, object request)
        {
            try
            {
                var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }

        }

        public async Task<bool> Delete<T>(int id)
        {
            try
            {
                var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

                
                return await url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<bool>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<T> GetAlbums<T>(int id, AlbumSearchRequest search)
        {
            try
            {
                var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}/Albums";

                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }

                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

        public async Task<T> GetTracks<T>(int ID)
        {
            try
            {
                var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{ID}/Tracks";

                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }

        }

    }
}
