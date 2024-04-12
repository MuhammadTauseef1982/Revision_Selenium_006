using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace Revision_Selenium_006
{
    [TestClass]
    public class UnitTest1 : BaseClass
    {
        LoginClass LoginClassObj = new LoginClass();
        BookingPage bookingPageObj = new BookingPage();
        ConfirmationPage confirmationPageObj = new ConfirmationPage();
        CustomerDetails customerDetailsObj = new CustomerDetails();
        //[TestMethod]


        // BaseClass baseclassobj = new BaseClass();       

        //public void Invalid_Case()
        //{
        //    Reporting();
        //    LoginClassObj.LoginMethod("Tauseef1234", "xyz123");

        //    CloseBrowser();
        //}
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "Book1.csv", "Book1#csv", DataAccessMethod.Sequential)]
        
        public void Valid_Case()
        {
            Reporting();
            string username = TestContext.DataRow["name"].ToString();
            string password = TestContext.DataRow["pass"].ToString();
            string locationBooking = TestContext.DataRow["location"].ToString();
            string hotelBooking = TestContext.DataRow["hotel"].ToString();
            string room_typeBooking = TestContext.DataRow["room_type"].ToString();
            string no_of_roomsBooking = TestContext.DataRow["no_of_rooms"].ToString();
            string check_in_dateBooking = TestContext.DataRow["check_in_date"].ToString();
            string check_out_dateBooking = TestContext.DataRow["check_out_date"].ToString();
            string adultBooking = TestContext.DataRow["adult"].ToString();
            string childrenBooking = TestContext.DataRow["children"].ToString();
            string firstConfirm = TestContext.DataRow["first"].ToString();
            string lastConfirm = TestContext.DataRow["last"].ToString();
            string address = TestContext.DataRow["add_Billing"].ToString();
            string CardNumber = TestContext.DataRow["creditcardNo"].ToString();
            string creditcardType = TestContext.DataRow["creditcard"].ToString();
            string MonthExpiry = TestContext.DataRow["CardMonthExpiry"].ToString();
            string ExpiryYear = TestContext.DataRow["ExpiryYear"].ToString();
            string cvvBooking = TestContext.DataRow["cvv"].ToString();


            LoginClassObj.LoginMethod(username, password);
            bookingPageObj.booking(locationBooking, hotelBooking, room_typeBooking, no_of_roomsBooking, check_in_dateBooking, check_out_dateBooking, adultBooking, childrenBooking);
            confirmationPageObj.confirmation();
            customerDetailsObj.customer(firstConfirm, lastConfirm, address, CardNumber, creditcardType, MonthExpiry, ExpiryYear, cvvBooking);

            //LoginClassObj.LoginMethod("Tauseef12345", "xyz123");
            //bookingPageObj.booking("Sydney", "Hotel Creek", "Standard", "2 - Two", "29/04/2024", "30/04/2024", "2 - Two", "2 - Two");
            //confirmationPageObj.confirmation();
            //customerDetailsObj.customer("Tauseef", "Amin", "Gulshan-e-Iqbal", "1234567891234560", "VISA", "May", "2030", "123");
            Thread.Sleep (10000);
            extentReports.Flush();
            //NEED TO SCROLL DOWN AND CLICK LOGOUT
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("window.scrollBy(0, 450)");

            driver.FindElement(By.Id("logout")).Click();
            CloseBrowser();
        }
    }
}
