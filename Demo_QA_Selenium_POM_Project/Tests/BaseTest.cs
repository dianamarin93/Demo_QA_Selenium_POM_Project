using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_QA_Selenium_POM_Project.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Demo_QA_Selenium_POM_Project.Tests
{
    public class BaseTest
    {
        protected WebDriver driver;
        protected HomePage homePage;
        protected LoginPage loginPage;
        [SetUp]

        public void Setup()
        {
            driver = new FirefoxDriver();
            homePage = new HomePage(driver);
            loginPage = new LoginPage(driver);
            driver.Navigate().GoToUrl("https://demoqa.com/books");
            driver.Manage().Window.Maximize();
        }
    }
}
