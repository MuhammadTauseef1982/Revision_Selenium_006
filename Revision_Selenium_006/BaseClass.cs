using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_Selenium_006
{
    public class BaseClass : ExtentReport
    {
        
        public static IWebDriver driver;
        public static void Reporting()
        {
            LogReport("Testing");
            exParentTest = extentReports.CreateTest("Adactin Hotel Extent Report");
            //exChildTest = exParentTest.CreateNode("Login");

        }
        [TestInitialize]
        // we can initialize browser, maximize screen, also call LogReport and exparenttest
        public static void Init()
        {
            var mydriver = new ChromeDriver();
            driver = mydriver;
            driver.Navigate().GoToUrl("https://adactinhotelapp.com/");
            driver.Manage().Window.Maximize();
        }
        //public static void ScreenSize() 
        //{
        //    driver.Manage().Window.Maximize();
        //}
        [TestCleanup]
        public static void CloseBrowser()
        {
            driver.Quit();
        }
        public static void write(IWebDriver driver, By by, string data, string details)
        {
            try
            {
                driver.FindElement(by).SendKeys(data);
                TakeScreenshot(driver, Status.Pass, details);
            }
            catch (Exception ex)
            {
                TakeScreenshot(driver, Status.Fail, "Text Fail" + ex);
            }
        }
        public static void click(IWebDriver driver, By by, string detail) 
        {
            try
            {
                driver.FindElement(by).Click();
                TakeScreenshot(driver, Status.Pass, detail);

            }
            catch (Exception ex)
            {
                TakeScreenshot(driver, Status.Fail, "Click Fail" + ex);
            }

        }
    }
}
