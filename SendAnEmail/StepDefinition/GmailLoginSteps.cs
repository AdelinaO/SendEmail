namespace SendAnEmail.StepDefinition
{
    using TechTalk.SpecFlow;
    using SendAnEmail.Page;
    using Specflow.FluentAutomation;
    using Page;
    using Specflow.FluentAutomation.Ext;

    [Binding]
    public class GmailLoginSteps
    {
        [Given(@"I navigated to Gmail page")]
        public void GivenINavigatedToGmailPage()
        {
            Pages.Get<HomePage>().Go();
        }
        
        [When(@"I choose '(.*)' option")]
        public void WhenIChooseOption(string p0)
        {
            Pages.Get<HomePage>().Register();
        }
        
        [When(@"I type the email adress ""(.*)""")]
        public void WhenITypeTheEmailAdress(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I continue")]
        public void WhenIContinue()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I type the password")]
        public void WhenITypeThePassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I keep continue")]
        public void WhenIKeepContinue()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
