﻿
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using UnitTestProject1.Pages;

namespace ConsoleApplication1.Steps
{
    [TestFixture]
    public class CreateSurvey
    {
        public IWebDriver driver;
        [Test]
        public void before()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void createsurveysucess()
        {
            SurveyListPage surveylistpage = new SurveyListPage(driver);
            SurveyListPage newsurvey = surveylistpage.createnewsurvey("danielpii");

                       
        }
        
  }
}
