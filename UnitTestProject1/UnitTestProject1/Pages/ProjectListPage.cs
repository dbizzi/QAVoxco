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
    public class ProjectListPage
    {

        private IWebDriver driver;

        public ProjectListPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        

    }
}