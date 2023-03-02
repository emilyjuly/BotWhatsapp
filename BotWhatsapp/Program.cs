using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BotWhatsapp
{

    class Program
    {

        static void Main(string[] args)
        {
            string url = "https://web.whatsapp.com";

            List<string> contatos = new List<string>()
            {
                "Teste do bot"
            };

            ChromeDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(url);

            driver.Manage().Window.Maximize();

            Thread.Sleep(10000);

            foreach (var contato in contatos)
            {
                Thread.Sleep(1000);

                var findEl = driver.FindElement(By.ClassName("Er7QU"));

                findEl.SendKeys(contato);

                Thread.Sleep(2000);

                var clickEl = driver.FindElement(By.ClassName("_8nE1Y"));

                clickEl.Click();

                Thread.Sleep(1000);

                var chatEl = driver.FindElement(By.ClassName("iq0m558w"));
                chatEl.SendKeys("Olá eu sou um robô");

                Thread.Sleep(1000);

                var sendEl = driver.FindElement(By.XPath("//span[@data-icon='send']"));
                sendEl.Click();

                Thread.Sleep(1000);
            }
        }
    }
}