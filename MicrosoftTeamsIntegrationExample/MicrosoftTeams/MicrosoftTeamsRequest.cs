using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftTeamsIntegrationExample.MicrosoftTeams
{
    public class MicrosoftTeamsRequest
    {
        [JsonProperty("@context")]
        public string Context { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("themeColor")]
        public string ThemeColor { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}