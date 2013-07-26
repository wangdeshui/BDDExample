using OpenQA.Selenium;

namespace BDD.SpecTests.PageObjects
{
    public static class RegisterPage
    {
        public static IWebElement EmailField
        {
            get { return Browser.Instance.FindElement(By.Id("Email")); }
        }

        public static IWebElement PasswordField
        {
            get { return Browser.Instance.FindElement(By.Id("Password")); }
        }

        public static IWebElement RegisterButton
        {
            get { return Browser.Instance.FindElement(By.Id("Register")); }
        }

        public static IWebElement MessageDiv
        {
            get { return Browser.Instance.FindElement(By.Id("Message")); }
        }
    }
}