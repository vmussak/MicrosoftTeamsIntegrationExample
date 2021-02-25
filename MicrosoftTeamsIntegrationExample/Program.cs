using MicrosoftTeamsIntegrationExample.MicrosoftTeams;
using System;
using System.Threading.Tasks;

namespace MicrosoftTeamsIntegrationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CadastrarCliente();

            Console.ReadKey();
        }

        public static void CadastrarCliente()
        {
            try
            {
                //tenta cadastrar o cliente aqui
                throw new Exception("Erro ao cadastrar o cliente");
            }
            catch (Exception ex)
            {
                var teamsRequest = new MicrosoftTeamsRequest
                {
                    Context = "https://schema.org/extensions",
                    Type = "MessageCard",
                    ThemeColor = "000",
                    Title = "Deu erro :(",
                    Text = "Erro ao cadastrar o cliente ABCD"
                };

                new MicrosoftTeamsService().SendMicrosoftTeamsMessage(teamsRequest);
                Console.WriteLine("Deu erro...");
            }
        }
    }
}
