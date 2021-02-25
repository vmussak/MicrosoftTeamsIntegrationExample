using MicrosoftTeamsIntegrationExample.MicrosoftTeams;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace MicrosoftTeamsIntegrationExample
{
    public class MicrosoftTeamsService
    {
        private static readonly HttpClient HttpClient = new HttpClient();

        public void SendMicrosoftTeamsMessage(MicrosoftTeamsRequest request)
        {
            var url = "SUA URL DO TEAMS AQUI";

            var jsonRequest = JsonConvert.SerializeObject(request);

            var response = HttpClient.PostAsync(
                url, 
                new StringContent(jsonRequest, Encoding.UTF8, "application/json")
            ).Result;

            if(response.IsSuccessStatusCode)
            {
                Console.WriteLine("Mensagem enviada ao MS Teams");
            }
            else
            {
                Console.WriteLine("Erro ao enviar mensagem ao MS Teams");
            }
        }
    }
}
