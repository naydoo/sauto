Feature: LoginDemo
	short demo on DaubG site

@mytag
Scenario: Login Unuccessful
	
	And I have imputed invalid login details
	When I click on the login button
	Then then i should not be prevented from login in
	
Scenario: Login Successful
	Given I am on bingo liner LIVE site
	And I have imputed valid login details
	When I press the login button
	Then then i should be directed to the games page
	When i click the logout button

Scenario: empty fields
	
	And I leave the fields empty
	When I click the login button
	Then then i should nnot be allowed to login
	

	
