using Gurubank.Featurefile;
using Gurubank.Pageobject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Gurubank.StepDef
{
    [Binding]
    public class ManagerLoginstepdef
    {
        ManagerLoginPageobject login = new ManagerLoginPageobject();

        [Given(@"I navigate to the gurubank webpage")]
        public void GivenINavigateToTheGurubankWebpage()
        {
            login.navigateWebPage();
        }

        [When(@"I enter UserId ""([^""]*)"", Password ""([^""]*)""")]
        public void WhenIEnterUserIdPassword(string userId, string password)
        {
            login.loginDetails();
        }

        [When(@"I click on Login")]
        public void WhenIClickOnLogin()
        {
            login.ClickLogin();
        }

        [Then(@"I should be loggedin successfully to Managers Page of GTPLC Bnank")]
        public void ThenIShouldBeLoggedinSuccessfullyToManagersPageOfGTPLCBnank()
        {
            
        }

    }
}
