using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeyflix.Services.Models.Response
{
    public class AuthenticationResponse
    {
        public User UserInformations { get; set; }

        public Session SessionInformation { get; set; }

        public string AccessToken { get; set; }

        public string ServerId { get; set; }

        public class User 
        {
            public string Name { get; set; }
            public string ServerId { get; set; }
            public string ServerName { get; set; }
            public Guid Id { get; set; }
            public string PrimaryImageTag { get; set; }
            public bool HasPassword { get; set; }
            public Configuration Configs { get; set; }

            public class Configuration {
                public string AudioLanguagePreference { get; set; }
                public bool PlayDefaultAudioTrack { get; set; }
                public string SubtitleLanguagePreference { get; set; }
                public bool DisplayMissingEpisodes { get; set; }
                public List<Guid> GroupedFolders { get; set; }
                public string SubtitleMode { get; set; }
                public bool EnableNextEpisodeAutoPlay { get; set; }
            }
        }

        public class Session
        { 
        
        }
    }
}
