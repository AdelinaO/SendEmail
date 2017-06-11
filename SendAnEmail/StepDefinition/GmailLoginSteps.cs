using System;
using TechTalk.SpecFlow;
using FluentAssertions;



namespace SendAnEmail

{
    [Binding]
    public class GmailLoginSteps
    {
        public object I { get; private set; }

        [Given(@"I navigated to gmail page")]
        public void GivenINavigatedToGmailPage()
        {

        }
        
        [When(@"I choose '(.*)' option \(\#identifierLink > div\.vdE(.*)Oc\.f(.*)GIQ\) \(//\*\[@id=""(.*)""]/div\[(.*)] xpath\)")]
        public void WhenIChooseOptionIdentifierLinkDiv_VdEOc_FGIQIdDivXpath(string p0, int p1, int p2, string p3, int p4)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I type the email \(\#identifierId\)\(//\*\[@id=""(.*)""] xpath\)")]
        public void WhenITypeTheEmailIdentifierIdIdXpath(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I execute the next button \(\#identifierNext > content > span\)\(//\*\[@id=""(.*)""]/content xpath\)")]
        public void WhenIExecuteTheNextButtonIdentifierNextContentSpanIdContentXpath(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I type the password \(\#password > div\.aCsJod\.oJeWuf > div > div\.Xb(.*)hP > input\)\(//\*\[@id=""(.*)""]/div\[(.*)]/div/div\[(.*)]/input xpath\)")]
        public void WhenITypeThePasswordPasswordDiv_ACsJod_OJeWufDivDiv_XbhPInputIdDivDivDivInputXpath(int p0, string p1, int p2, int p3)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I execute the next button \(\#passwordNext > content\)\(//\*\[@id=""(.*)""]/content xpath\)")]
        public void WhenIExecuteTheNextButtonPasswordNextContentIdContentXpath(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be logged in --assert")]
        public void ThenIShouldBeLoggedIn_Assert()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
