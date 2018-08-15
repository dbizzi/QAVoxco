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
            driver.FindElement(By.ClassName("acuity-tab")).Click();
            driver.FindElement(By.ClassName("button dropdown-toggle important")).Click();
            driver.FindElement(By.ClassName("h-new-survey")).Click();
            driver.FindElement(By.ClassName("field")).FindElement(By.Id("Name")).SendKeys(surveyname);
            driver.FindElement(By.ClassName("footer fixed")).FindElement(By.Id("Submit1")).Click();

            return new SurveyListPage(driver);
        }
    }
}
