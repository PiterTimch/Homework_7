using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfClient.Models;
using System.Net.Http;
using System.Security.Policy;
using WpfClient.Constants;

namespace WpfClient.Services
{
    public class MessageService
    {
        public MessageService() 
        {
            _httpClient = new HttpClient();
            _url = "http://api.mobizon.ua";
        }

        public async Task<MessageResponse> SendMessage(MessagePostRequests messageToSend) 
        {
            string json = JsonConvert.SerializeObject(messageToSend, new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented
            });

            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{_url}/service/message/sendSmsMessage?output=json&api=v1&apiKey={MessageApiConstants.ApiKey}", content);

            if (response.IsSuccessStatusCode)
            {
                string jsonResp = await response.Content.ReadAsStringAsync();
                if (jsonResp.Contains('['))
                {
                    throw new Exception("Invalid sending");
                }
                return JsonConvert.DeserializeObject<MessageResponse>(jsonResp);
            }

            throw new Exception("Invalid sending");
        }

        private readonly HttpClient _httpClient;
        private readonly string _url;
    }
}
