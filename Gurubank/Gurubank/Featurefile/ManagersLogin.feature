Feature: ManagersLogin

In order for manager tp update customers details
Manager needs to login

@tag1
    Scenario:  Manager Login
	Given I navigate to the gurubank webpage
	When I enter UserId "<UserId>", Password "<Password>"
	And I click on Login
	Then I should be loggedin successfully to Managers Page of GTPLC Bnank

