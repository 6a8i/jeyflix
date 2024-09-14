using jeyflix.Commons;
using jeyflix.Services.Models.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeyflix.Services.Implentations
{
    public class SystemService : ISystemService
    {
        public SystemService()
        {
            
        }


        public async Task<ServerPublicInformationResponse> GetServerPublicInformationAsync()
        {
            var result = await HttpClientCommon.client.GetAsync("/system/info/public");

            if (result.IsSuccessStatusCode)
            {
                var stringResponse = await result.Content.ReadAsStringAsync();
                var serverInfo = JsonConvert.DeserializeObject<ServerPublicInformationResponse>(stringResponse);
                return serverInfo;
            }

            return default;
        }
    }
}
