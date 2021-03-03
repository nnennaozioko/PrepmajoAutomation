
using OpenQA.Selenium;
using PrepMajorAutomation.PageObject;
using System;
using TechTalk.SpecFlow;

namespace PrepMajorAutomation.Steps
{
    [Binding]
    public class SearchSteps
    {
        SearchPageObject searchPageObject;


        public SearchSteps()
        {
            searchPageObject = new SearchPageObject();
           
        }

        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            searchPageObject.Navigate(url);
           
        }
        
        [When(@"I clicked on the search field")]
        public void WhenIClickedOnTheSearchField()
        {
            searchPageObject.SearchField();
        }
        
        [When(@"I type ""(.*)"" in the search feild")]
        public void WhenITypeInTheSearchFeild(string p0)
        {
            searchPageObject.SearchField();
        }
        
        [When(@"I click the search button")]
        public void WhenIClickTheSearchButton()
        {
            searchPageObject.SearchButton();
        }
        
        [Then(@"the result page should display")]
        public void ThenTheResultPageShouldDisplay()
        {
            
        }
    }
}
