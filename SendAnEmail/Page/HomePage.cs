namespace SendAnEmail.Page
{
    using FluentAutomation;

    public class HomePage : PageObject<HomePage>
    {
        public HomePage(FluentTest test)
            : base(test)
        {
            // the url of the page
            Url = @"http://www.gmail.com/";
            // the element to search for to make sure we are on the right page
            At = () => I.Expect.Exists("#identifierLink > div.vdE7Oc.f3GIQ > p");
        }

        public void Register()
        {
            //choose 'use another account' option
            I.Click("#identifierLink > div.vdE7Oc.f3GIQ");
            //Type the email adress
            I.Type("#identifierId");
            //Click on the next button
            I.Click("#identifierNext > content > span");
            //Type the password
            I.Type("#password > div.aCsJod.oJeWuf > div > div.Xb9hP > input");
            //Click on the next button
            I.Click("#passwordNext > content > span");

        }
    }
}
