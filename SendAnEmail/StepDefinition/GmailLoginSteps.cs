namespace SendAnEmail.StepDefinitions
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
        
        [When(@"I choose Use another account option")]
        public void WhenIChooseUseAnotherAccountOption()
        {
            Pages.Get<HomePage>().Register();
        }
        
        [Then(@"I type the ""(.*)""")]
        public void ThenITypeThe(string p0)
        {
            Pages.Get<HomePage>().TypeEmail();
        }
        
        [Then(@"I continue")]
        public void ThenIContinue()
        {
            Pages.Get<HomePage>().GoNext();
        }

        [Then(@"I type again, the ""(.*)""")]
        public void ThenITypeAgainThe(string p0)
        {
            Pages.Get<HomePage>().TypePassword();

        }


        [Then(@"I keep continue")]
        public void ThenIKeepContinue()
        {
            Pages.Get<HomePage>().GoNextAgain();
        }
        
        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            Pages.Get<HomePage>().IExpectExists();
        }
    }
}
