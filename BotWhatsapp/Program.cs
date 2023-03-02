using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BotWhatsapp
{

    class Program
    {

        static void Main(string[] args)
        {
            string url = "https://web.whatsapp.com";


            //Lista com os contatos que serão pesquisados no seu Whatsapp e receberão a mensagem
            List<string> contatos = new List<string>()
            {
                "Help4you"
            };

            //Criando instância do ChromeDriver
            ChromeDriver driver = new ChromeDriver();

            //Levando o navegador até a URL desejada
            driver.Navigate().GoToUrl(url);

            //Maximizando a janela do navegador
            driver.Manage().Window.Maximize();

            //Automatizado irá aguardar o usuário scannear o QR Code do whatsapp web em seu celular
            Thread.Sleep(10000);

            foreach (var contato in contatos)
            {
                //Esperando elemento aparecer na tela para buscar
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

                //Achando a caixa de pesquisa
                var findEl = driver.FindElement(By.ClassName("Er7QU"));

                //Enviando para a janela de busca a string da lista de contatos criada a cima
                findEl.SendKeys(contato);
            }
        }
    }
}