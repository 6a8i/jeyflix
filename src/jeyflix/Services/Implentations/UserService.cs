using jeyflix.Commons;
using jeyflix.Services.Models.Request;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace jeyflix.Services.Implentations
{
    public class UserService : IUserService
    {
        public async Task AuthenticateByNameAsync(AuthenticateUserByNameRequest request)
        {
            string jsonData = JsonConvert.SerializeObject(request);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await HttpClientCommon.client.PostAsync("/users/authenticatebyname", content);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                //var user = JsonConvert.DeserializeObject<>(result);
            }
            
        }
    }
}
