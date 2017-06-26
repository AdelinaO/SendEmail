namespace SendAnEmail.Page
{
    using FluentAutomation;

    public class HomePage : PageObject<HomePage>
    {
        public HomePage(FluentTest test)
            : base(test)
        {
            // the url of the page
            Url = @"https://mail.google.com/";
            // the element to search for to make sure we are on the right page
            At = () => I.Expect.Exists("#identifierLink > div.vdE7Oc.f3GIQ > p");
        }

        public void Register()
        {
            //choose 'use another account' option
            I.Click("#identifierLink > div.vdE7Oc.f3GIQ");

        }

        public void TypeEmail()
        {
            //Type the email adress
            I.Type("#identifierId");
        }

        public void GoNext()

        {
            //Click on the next button
            I.Click("#identifierNext > content > span");

        }


        public void TypePassword()
        {

            //Type the password
            I.Type("#password > div.aCsJod.oJeWuf > div > div.Xb9hP > input");

        }


        public void GoNextAgain()
        {

            //Click on the next button
            I.Click("#passwordNext > content > span");

        }

        public void IExpectExists()
        {

            I.Expect.Exists("#gbq1 > div > a > span");
        }

    }
}
