using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_Selenium_006
{
    internal class CustomerDetails : BaseClass
    {
        By FirstName = By.Id("first_name");
        By LastName = By.Id("last_name");
        By Address = By.Id("address");
        By CardNumber = By.Id("cc_num");
        By CardType = By.Id("cc_type");
        By ExpMonth = By.Id("cc_exp_month");
        By ExpYear = By.Id("cc_exp_year");
        By CVVNumber = By.Id("cc_cvv");
        By Bookingconf = By.Id("book_now");

        public void customer(string firstname, string lastname, string add, string CNumber, string CType, string Emonth, string Eyear, string cvv)
        {
            exChildTest = exParentTest.CreateNode("Enter Customer Details");
            write(driver, FirstName, firstname, "First Name");
            write(driver, LastName, lastname, "Last Name");
            write(driver, Address, add, "Customer Address");
            write(driver, CardNumber, CNumber, "Credit Card Number");
            write(driver, CardType, CType, "Credit Card Type");
            write(driver, ExpMonth, Emonth, "card expiry month");
            write(driver, ExpYear, Eyear, "card expiry year");
            write(driver, CVVNumber, cvv, "CVV Number");
            click(driver, Bookingconf, "Booking of Hotel");
            
        }
    }
}
