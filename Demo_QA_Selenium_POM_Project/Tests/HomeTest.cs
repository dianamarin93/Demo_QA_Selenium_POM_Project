using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_QA_Selenium_POM_Project.Pages;
using NUnit.Framework;

namespace Demo_QA_Selenium_POM_Project.Tests
{
    class HomeTest : BaseTest
    {
        [Test]
        public void AddBookToCollectionTest()
        {
            homePage.ClickLoginButton();
            loginPage.Login();
            loginPage.WaitForSeconds(1);
            homePage.SelectFirstBook();
            loginPage.WaitForSeconds(1);
            homePage.ScrollAndClickAddToCollection();
            homePage.ConfirmAlertBox();
        }
    }
}
