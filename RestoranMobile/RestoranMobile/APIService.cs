using Flurl.Http;
using Restoran.Model;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.Generic;

namespace RestoranMobile
{
    public class APIService
    {
        private readonly string route = null;

        public static string password { get; set; }
        public static string username { get; set; }
#if DEBUG
      private  string _APIUrl = "http://192.168.100.12:54813/api";
#endif
#if RELEASE
    private    string _APIUrl = "https://stranica.com:44359/api";

#endif
        public APIService(string ruta)
        {
            route = ruta;
        }
        public async Task<T> Get<T>(object search)
        {
            var url = $"{_APIUrl}/{route}";
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
                    //  MessageBox.Show("Niste authentificirani");
                    await  Application.Current.MainPage.DisplayAlert("Greska","Niste autentificirani","OK");
                }
                throw;
            }

        }


        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_APIUrl}/{route}/{id}";


            return await url.WithBasicAuth(username, password).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_APIUrl}/{route}";

            return await url.WithBasicAuth(username, password).PostJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{_APIUrl}/{route}/{id}";

 

            return await url.WithBasicAuth(username, password).PutJsonAsync(request).ReceiveJson<T>();
        }
  
    }
}
