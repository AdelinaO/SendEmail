using System;
using TechTalk.SpecFlow;

namespace SendAnEmail
{
    [Binding]
    public class GmailLoginSteps
    {
        [When(@"I keep continue")]
        public void WhenIKeepContinue()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
