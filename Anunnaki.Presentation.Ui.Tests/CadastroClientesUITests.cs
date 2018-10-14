using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Anunnaki.Presentation.Ui.Tests
{
    public class CadastroClientesUITests
    {
        public void TestMethod1()
        {
            try
            {
                //abrir navegador
                IWebDriver driver = new ChromeDriver();

                //Abrir maximizado
                driver.Manage().Window.Maximize();

                //Abrir a página de cadastrao de conta
                driver.Navigate().GoToUrl("http://localhost:88/public/#/CriarConta");

                //preencher o email do usuário...
                IWebElement email = driver.FindElement(By.CssSelector("Email"));
                email.Clear(); //Limpar o conteúdo do campo

                Random r = new Random();
                email.SendKeys($"sergio.coti{r.Next(1, 9999999)}@gmail.com");

            }
            catch (Exception ex)
            {
                Assert.Fail("Teste Falhou " + ex.Message);
                throw;
            }
        }
    }
}
