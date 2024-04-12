using AventStack.ExtentReports.Reporter.Configuration;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_Selenium_006
{
    public class ExtentReport
    {
        public static ExtentReports extentReports;
        public static ExtentTest exParentTest;
        public static ExtentTest exChildTest;
        public static string dirpath;

        public static void LogReport(string testcase)
        {
            extentReports = new ExtentReports();

            //dirpath = @"..\..\TestExecutionReports\" + '_' + testcase;
            dirpath = @"..\..\TestExecutionReports\ExtentReport" + DateTime.Now.ToString("yyyyMMddHHmmss") + '_' + testcase  ;

            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(dirpath);

            htmlReporter.Config.Theme = Theme.Standard;

            extentReports.AttachReporter(htmlReporter);
        }

        public static void TakeScreenshot(IWebDriver driver, Status status, string stepDetail)
        {

           // string path = @"E:\repos\Revision_Selenium_006\Revision_Selenium_006\bin\ScreenShot\" + "TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            string path = @"E:\repos\Revision_Selenium_006\Revision_Selenium_006\bin\ScreenShot\" + stepDetail+"_" + DateTime.Now.ToString("D_"+"ddMMyyyy"+"_T_"+"HHmmss");
            Screenshot image_username = ((ITakesScreenshot)driver).GetScreenshot();
            image_username.SaveAsFile(path + ".png", ScreenshotImageFormat.Png);
            ExtentReport.exChildTest.Log(status, stepDetail, MediaEntityBuilder
                .CreateScreenCaptureFromPath(path + ".png").Build());


        }
    }
}
