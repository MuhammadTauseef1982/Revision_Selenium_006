using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_Selenium_006
{
    internal class ConfirmationPage : BaseClass
    {
        By confirmHotel = By.Id("radiobutton_0");
        By confirmOption = By.Id("continue");
        public void confirmation()
        {
            exChildTest = exParentTest.CreateNode("Confirmation of Booking");
            click(driver, confirmHotel, "Confirmation Hotel");
            click(driver, confirmOption, "Hotel Confirmed");
        }
    }
}
