using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Demo_QA_Selenium_POM_Project.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(WebDriver driver) : base(driver)
        {
        }

        private IWebElement lgnBtn => driver.FindElement(By.CssSelector("#login"));
        private IWebElement usernameLabel => driver.FindElement(By.XPath("//label[@id='userName-value']"));
        private IWebElement firstBook => driver.FindElement(By.XPath("//a[contains(text(), 'Git Pocket Guide')]"));
        private IWebElement addButton => driver.FindElement(By.XPath("(//button[@id='addNewRecordButton']) [2]"));
        public void ClickLoginButton()
        {
            lgnBtn.Click();
        }

        public string GetLabelText()
            => usernameLabel.Text;

        public void SelectFirstBook() => ClickElement(firstBook);

        public void ScrollAndClickAddToCollection()
        {
            ScrollAndClick(addButton);
        } 
    }
}
