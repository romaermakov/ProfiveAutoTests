using atFrameWork2.SeleniumFramework;
using ATframework3demo.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATframework3demo.PageObjects
{
    public class MainPage
    {
        internal ProfiveSettingsPage ClickUserName()
        {
            var btnUser = new WebItem("//a[@href='/personal']]", "Клик на имя пользователя");
            btnUser.Click();

            return new ProfiveSettingsPage();
        }
    }
}
