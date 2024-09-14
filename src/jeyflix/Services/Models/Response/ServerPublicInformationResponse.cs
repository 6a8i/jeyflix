using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeyflix.Services.Models.Response
{
    public class ServerPublicInformationResponse
    {
        public string LocalAddress { get; set; }
        public string ServerName { get; set; }
        public string Version { get; set; }
        public string ProductName { get; set; }
        public string Id { get; set; }
        public bool StartupWizardCompleted { get; set; }
    }
}
