using OpenQA.Selenium;
using PrepMajorAutomation.Hooks;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrepMajorAutomation.PageObject
{
    class SearchPageObject
    {
        IWebDriver driver;
        
        public SearchPageObject()
        {
            driver = WebHook.driver;
        }

        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        IWebElement searchField => driver.FindElement(By.Id("search-courses-input"));
        IWebElement searchButton => driver.FindElement(By.CssSelector("#stm_lms_courses_search > a"));

        public void SearchField()
        {
            searchField.Click();
        }
        public void SearchField(string txt)
        {
            searchField.SendKeys(txt);
        }
        public void SearchButton()
        {
            searchButton.Click();
        }
    } 


}
