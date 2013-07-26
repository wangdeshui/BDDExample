using System;
using BDD.SpecTests.PageObjects;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace BDD.SpecTests.Steps
{
    [Binding]
    public class RegisterSteps
    {

        [Given(@"I have navigated to the register page")]
        public void GivenIHaveNavigatedToTheRegisterPage()
        {
            Browser.Instance.Navigate().GoToUrl(TestHelper.HostUrl);
        }
        
        [Given(@"I have filled in my '(.*)' into the email field")]
        public void GivenIHaveFilledInMyIntoTheEmailField(string p0)
        {
            RegisterPage.EmailField.SendKeys(p0);
        }
        
        [Given(@"I have not registered with my email address '(.*)' before")]
        public void GivenIHaveNotRegisteredWithMyEmailAddressBefore(string p0)
        {
            
        }

        [Given(@"I have filled in my '(.*)' into the password field")]
        public void GivenIHaveFilledInMyIntoThePasswordField(string p0)
        {
            RegisterPage.PasswordField.SendKeys(p0);
        }

        
        [When(@"I click the register button")]
        public void WhenIClickTheRegisterButton()
        {
            RegisterPage.RegisterButton.Click();
        }


    
        [Then(@"I see the  '(.*)'")]
        public void ThenISeeThe(string p0)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Instance, TimeSpan.FromSeconds(500));
            wait.Until((d) => d.FindElements(By.Id("Message")).Count>0);

            RegisterPage.MessageDiv.Text.Should().Contain(p0);


        }
    }
}
