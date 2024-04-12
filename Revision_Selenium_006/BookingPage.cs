using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_Selenium_006
{
    internal class BookingPage : BaseClass
    {
        By location = By.Id("location");
        By hotel = By.Id("hotels");
        By roomtype = By.Id("room_type");
        By roomNo = By.Id("room_nos");
        By dateIn = By.Id("datepick_in");
        By dateOut = By.Id("datepick_out");
        By adultroom = By.Id("adult_room");
        By childroom = By.Id("child_room");
        By submit = By.Id("Submit");

        public void booking(string loc, string hot, string roomType, string roomNumber, string daIn, string daOut, string adRoom, string chRoom)
        {
            exChildTest = exParentTest.CreateNode("Booking Screens for Customer");
            write(driver, location, loc, "Enter Location");
            write(driver, hotel, hot, "Enter Hotel");
            write(driver, roomtype, roomType, "Room details");
            write(driver, roomNo, roomNumber, "Room Number confirmed");
            driver.FindElement(By.Id("datepick_in")).Clear();
            write(driver, dateIn, daIn, "Check In Date");
            driver.FindElement(By.Id("datepick_out")).Clear();
            write(driver, dateOut, daOut, "Check Out Date");
            write(driver, adultroom, adRoom, "Number of Adult Rooms");
            write(driver, childroom, chRoom, "Number of Children Rooms");
            click(driver, submit, "Confirmed your Reservation");
        }
    }
}
