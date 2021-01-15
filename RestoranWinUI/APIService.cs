using Flurl.Http;
using Restoran.Model;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranWinUI
{
    public class APIService
    {
        private readonly string route = null;

        public static string password { get; set; }
        public static string username { get; set; }

        public APIService(string ruta)
        {
            route = ruta;
        }
        public async Task<T> Get<T>(object search)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{route}";
            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }
                return await url.WithBasicAuth(username, password).GetJsonAsync<T>();

            }
            catch (FlurlHttpException ex)
            {
                var sc = (int)System.Net.HttpStatusCode.Unauthorized;
                if (ex.Call.Response.StatusCode == sc)
                {
                    MessageBox.Show("Niste authentificirani");
                }
                throw;
            }

        }


        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{route}/{id}";

            try
            {
                return await url.WithBasicAuth(username, password).GetJsonAsync<T>();

            }
            catch (FlurlHttpException ex)
            {
                var sc =(int) System.Net.HttpStatusCode.Unauthorized;
                if (ex.Call.Response.StatusCode == sc)
                {
                    MessageBox.Show("Niste authentificirani");
                }
                throw;
            }
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{route}";

            try
            {
                return await url.WithBasicAuth(username, password).PostJsonAsync(request).ReceiveJson<T>();

            }
            catch (FlurlHttpException ex)
            {
                var sc = (int)System.Net.HttpStatusCode.Unauthorized;
                if (ex.Call.Response.StatusCode == sc)
                {
                    MessageBox.Show("Niste authentificirani");
                }
                throw;
            }
        }

        public async Task<T> InsertKupac<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{route}/InsertKupac";

            try
            {
                return await url.WithBasicAuth(username, password).PostJsonAsync(request).ReceiveJson<T>();

            }
            catch (FlurlHttpException ex)
            {
                var sc = (int)System.Net.HttpStatusCode.Unauthorized;
                if (ex.Call.Response.StatusCode == sc)
                {
                    MessageBox.Show("Niste authentificirani");
                }
                throw;
            }
        }
        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{route}/{id}";

            try
            {
                return await url.WithBasicAuth(username, password).PutJsonAsync(request).ReceiveJson<T>();

            }
            catch (FlurlHttpException ex)
            {
                var sc = (int)System.Net.HttpStatusCode.Unauthorized;
                if (ex.Call.Response.StatusCode == sc)
                {
                    MessageBox.Show("Niste authentificirani");
                }
                throw;
            }
        }
   
    }
}
