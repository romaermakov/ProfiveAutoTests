using atFrameWork2.BaseFramework.LogTools;
using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace atFrameWork2.PageObjects
{
    class PortalLoginPage
    {
        PortalInfo portalInfo;

        public PortalLoginPage(PortalInfo portal)
        {
            portalInfo = portal;
        }

        public PortalHomePage Login(User admin)
        {
            DriverActions.OpenUri(portalInfo.PortalUri);
            var loginBtn = new WebItem("//a[@href='/login']", "Кнопка логина");
            var loginField = new WebItem("//input[@type='email']", "Поле для ввода логина");
            var pwdField = new WebItem("//input[@type='password']", "Поле для ввода пароля");
            var loginBtn2 = new WebItem("//div[@class = 'login-text']", "Кнопка входа");

            loginBtn.Click();
          

            loginField.SendKeys(admin.Login);
            Thread.Sleep(1000);

            loginField.SendKeys(Keys.Enter);
            pwdField.SendKeys(admin.Password, logInputtedText: false);
            Thread.Sleep(1000);

            pwdField.SendKeys(Keys.Enter);

            loginBtn2.Click();

            return new PortalHomePage();
        }
    }
}
