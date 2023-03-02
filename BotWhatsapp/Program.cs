using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BotWhatsapp
{

    class Program
    {

        static void Main(string[] args)
        {
            string url = "https://web.whatsapp.com";

            //Local para inserir o contato que será buscado para enviar a mensagem
            List<string> contatos = new List<string>()
            {
                "Teste do bot"
            };

            //Criando uma nova instância do ChromeDriver
            ChromeDriver driver = new ChromeDriver();

            //Abrindo URL
            driver.Navigate().GoToUrl(url);

            //Maximizando janela do navegador
            driver.Manage().Window.Maximize();

            //Esperando
            Thread.Sleep(10000);

            //Buscando o contato minha lista de contatos
            foreach (var contato in contatos)
            {
                //Esperando
                Thread.Sleep(1000);

                //Achando a caixa de busca do whatsapp web
                var findEl = driver.FindElement(By.ClassName("Er7QU"));

                //Digitando o nome do contato na caixa de busca
                findEl.SendKeys(contato);

                //Esperando
                Thread.Sleep(2000);

                //Buscando a conversa 
                var clickEl = driver.FindElement(By.ClassName("_8nE1Y"));

                //Clicando na conversa
                clickEl.Click();

                //Esperando
                Thread.Sleep(1000);

                //Buscando caixa de texto do chat 
                var chatEl = driver.FindElement(By.ClassName("iq0m558w"));

                //Enviando mensagem 
                chatEl.SendKeys("Olá eu sou um robô");

                //Esperando
                Thread.Sleep(1000);

                //Buscando botão de enviar mensagem
                var sendEl = driver.FindElement(By.XPath("//span[@data-icon='send']"));

                //Clicando no botão para enviar mensagem
                sendEl.Click();

                //Esperando mensagem ser enviada antes de fechar
                Thread.Sleep(3000);
            }
        }
    }
}