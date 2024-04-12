using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_Selenium_006
{
    internal class LoginClass : BaseClass
    {
        By usernametxt = By.Id("username");
        By passwordtxt = By.Id("password");
        By loginbtn = By.Id("login");

        public void LoginMethod(string username, string password)
        {
            Init();
           // ScreenSize();
            exChildTest = exParentTest.CreateNode("Login");
            write(driver, usernametxt, username,"Enter UserName");
            write(driver, passwordtxt, password, "Enter Password");
            click(driver, loginbtn, "Click login Button");
            
        }    
    }
}
