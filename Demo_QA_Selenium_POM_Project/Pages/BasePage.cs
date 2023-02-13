using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace Demo_QA_Selenium_POM_Project.Pages
{
    public class BasePage
    {
        public WebDriver driver;

        public BasePage(WebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickElement(IWebElement el)
        {
            el.Click();
        }

        public void InputText(IWebElement el, string text)
        {
            el.SendKeys(text);
        }

        public string GetText(IWebElement el)
            => el.Text;

        public void WaitForSeconds(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }

        public void ConfirmAlertBox() => driver.SwitchTo().Alert().Accept();

        public void ScrollAndClick(IWebElement el)
        {
            Actions actions = new Actions(driver);
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript(string.Format($"window.scrollTo(0, {el.Location.Y}"));
            actions.Click(el).Perform();
        }
    }
    
}
