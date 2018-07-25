Feature: LoginDemo
	short demo on DaubG site

@mytag
Scenario: Login Successful
	Given I am on bingo liner LIVE site
	And I have imputed valid login details
	When I press the login button
	Then then i should be directed to the games page
	When i click the logout button
	Then i should be logged out successfully

	
