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

namespace UnitTestProject1.Pages
{
    
    public class SurveyListPage
    {
        private IWebDriver driver;

        public SurveyListPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public SurveyListPage createnewsurvey(String surveyname)
        {

            driver.FindElement(By.LinkText("Surveys")).Click();

            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='View Recycle Bin'])[1]/following::div[2]")).Click();
            
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='New'])[1]/following::a[1]")).Click();
            
            driver.FindElement(By.Id("Name")).SendKeys(surveyname);
            driver.FindElement(By.Id("submit1")).Click();

            return new SurveyListPage(driver);
        }
        public Boolean IsElementPresent()
        {
            try
            {
                driver.FindElement(By.ClassName("name-label v-nameLabel"));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

    }
}
