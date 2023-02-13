using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_QA_Selenium_POM_Project.Utils;
using OpenQA.Selenium;

namespace Demo_QA_Selenium_POM_Project.Pages
{
    public class LoginPage : BasePage
    {
      
        public LoginPage(WebDriver driver) : base(driver)
        {
        }

        private IWebElement usernameElement => driver.FindElement(By.CssSelector("#userName"));
        private IWebElement passwordElement => driver.FindElement(By.CssSelector("#password"));
        private IWebElement loginButton => driver.FindElement(By.CssSelector("#login"));

        public void Login()
        {
            InputText(usernameElement, Constants.Username);
            InputText(passwordElement, Constants.Password);
            ClickElement(loginButton);
        }
    }
}
