using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MobileServerClient.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PCLCrypto;
using ServerClient.Models;
using Simple.OData.Client;
using Validation;

namespace ServerClient
{
    public class Communicator
    {
        #region field
        private ODataClientSettings _settings = new ODataClientSettings();
        private string _token;
        private HttpClient _httpClient;
        private string _httpUrl;
        private string _userName;
        private string _password;
        #endregion

        #region constructor
        /// <summary>
        /// constructor, need to provide the odata service address
        /// </summary>
        /// <param name="serviceUrl">server url</param>
        public Communicator(string serviceUrl)
        {
            _httpClient = new HttpClient { MaxResponseContentBufferSize = 256000 };
            V4Adapter.Reference();
            _httpUrl = serviceUrl;
            _settings.UrlBase = serviceUrl + "odata/";
            _settings.RequestTimeout = new TimeSpan(0, 0, 5);
        }
        #endregion

        #region private method
        /// <summary>
        /// get token from the server, expired after one day.
        /// </summary>
        /// <param name="username">user name</param>
        /// <param name="password">password</param>
        private void GetToken(string username, string password)
        {
            string str = "grant_type=password&username=" + username + "&password=" + password;
            var uri = new Uri(string.Format(_httpUrl + "token", string.Empty));
            var content = new StringContent(str, Encoding.UTF8, "application/json");

            var response = _httpClient.PostAsync(uri, content);
            var responseContent = response.Result.Content.ReadAsStringAsync();
            var result = responseContent.Result;
            TokenObj token = JsonConvert.DeserializeObject<TokenObj>(result);
            _token = token.access_token;
        }

        /// <summary>
        ///     encrypt password
        /// </summary>
        /// <param name="passwd">password</param>
        /// <returns>encrypted password</returns>
        private string Encrypt(string passwd)
        {
            var hasher = WinRTCrypto.HashAlgorithmProvider.OpenAlgorithm(HashAlgorithm.Sha256);
            var source = Encoding.UTF8.GetBytes(passwd);
            var crypto = hasher.HashData(source);
            var sb = new StringBuilder();
            foreach (var item in crypto)
                sb.Append(item.ToString("X2"));
            return sb.ToString();
        }
        #endregion


        /// <summary>
        ///     get the login result, if connection fail, it will throw an exception. Connection timeout 5 seconds.
        /// </summary>
        /// <param name="username">user name</param>
        /// <param name="password">password</param>
        /// <returns>Type:String, if is it String.Empty, Login fail, else it will return the name init.</returns>
        public string AuthResult(string username, string password)
        {
            _userName = username;
            _password = Encrypt(password);
            GetToken(_userName, _password);
            _settings.BeforeRequest = (message) =>
            {
                message.Headers.TryAddWithoutValidation("Authorization", "bearer " + _token);
            };
            var client = new ODataClient(_settings);
            if (password == null)
                return "";
            var logins = client
                .FindEntryAsync("MobileLogins/Default.GetLoginResults(username='" + username + "')").Result;
            return logins["__result"].ToString().Length == 0 ? "" : logins["__result"].ToString();
        }

        /// <summary>
        ///     Get a list of Assigned Inspection Tasks
        /// </summary>
        /// <param name="init">name init</param>
        /// <returns>the list of tasks</returns>
        public List<AssignInspectionTaskToMobile> GetAssignedInspectionTask(string init)
        {
            _settings.BeforeRequest = (message) =>
            {
                message.Headers.TryAddWithoutValidation("Authorization", "bearer " + _token);
            };
            var client = new ODataClient(_settings);
            if (string.IsNullOrEmpty(init))
                throw new Exception("No name Inital exception");
            var tasks = client
                .FindEntriesAsync("AssignInspectionTaskToMobiles?$filter=NameInit eq '" + init +
                                  "' and IsCompeleted eq false").Result;
            var list = new List<AssignInspectionTaskToMobile>();
            foreach (var item in tasks)
            {
                var task = new AssignInspectionTaskToMobile
                {
                    AssignDate = ((DateTimeOffset)item["AssignDate"]).LocalDateTime,
                    IsCompeleted = (bool)item["IsCompeleted"],
                    NameInit = item["NameInit"].ToString()
                };
                if (item["ComponentID"] != null)
                    task.ComponentID = (int)item["ComponentID"];
                else
                    task.ComponentID = null;
                task.Id = (int)item["Id"];
                if (item["LIDComponentID"] != null)
                {
                    task.LIDComponentID = (int)item["LIDComponentID"];
                    task.Frequency = item["Frequency"].ToString();
                }
                else
                {
                    task.LIDComponentID = null;
                    task.Frequency = null;
                }
                list.Add(task);
            }
            return list;
        }
    }
}