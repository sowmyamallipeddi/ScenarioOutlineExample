using BankAccount;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowBank.StepDefinitions
{
    [Binding]
    public class RequestLoanStepDefinitions
    {
        private User user;
        private List<User> users;

        [Given(@"John has a total balance of (.*)")]
        public void GivenJohnHasATotalBalanceOf(int p0)
        {
            Assert.Equal(1000, p0);
        }

        [When(@"he applies for a loan of (.*)")]
        public void WhenHeAppliesForALoanOf(int amount)
        {

        }

        [Then(@"his loan application is approved")]
        public void ThenHisLoanApplicationIsApproved()
        {

        }

        [Given(@"he has a monthly income of (.*)")]
        public void GivenHeHasAMonthlyIncomeOf(int income)
        {

        }

        [Then(@"his loan application is denied")]
        public void ThenHisLoanApplicationIsDenied()
        {

        }
    }
}
