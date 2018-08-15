using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace ConsoleApplication1
{
    class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public LoginPage visit(String url)
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }

        public LoginPage validation(String user, String password, String context)
        {
            driver.FindElement(By.Id("UserName")).SendKeys(user);
            driver.FindElement(By.Id("Password")).SendKeys(password);
            driver.FindElement(By.Id("Context")).SendKeys(context);
            driver.FindElement(By.Id("submit-btn")).Click();

            return new LoginPage(driver);
        }

        public Boolean isValid()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("dropdown-toggle")));
            return HaveNavigationBar() && HaveProjectList();
        }

        private Boolean HaveNavigationBar()
        {
            return driver.FindElement(By.Id("main-header")) != null;
        }

        private Boolean HaveProjectList()
        {
            return driver.FindElement(By.ClassName("dropdown-toggle")) != null;
        }



    }
}


