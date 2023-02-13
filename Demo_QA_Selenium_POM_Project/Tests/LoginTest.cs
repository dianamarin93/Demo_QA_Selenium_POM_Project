using System.Threading;
using Demo_QA_Selenium_POM_Project.Pages;
using Demo_QA_Selenium_POM_Project.Tests;
using Demo_QA_Selenium_POM_Project.Utils;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Demo_QA_Selenium_POM_Project
{
    public class LoginTest : BaseTest
    {
        
        [Test]
        public void Login_Test()
        {
            HomePage homePage = new HomePage(driver);
            homePage.ClickLoginButton();

            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login();

        }
    }
}