Feature: Login
	In order to acces my online benefits
	As a user
	I want to login using my credentials

@bademail
Scenario: login to myrcp with invalid email
	Given I have navigated to the myrcp login page
	And  I have entered an invalid email address 
	And I have entered a valid password
	When I press login
	Then I get an invalid credentials message 

@badpassword
Scenario: login to myrcp with invalid password
	Given I have navigated to the myrcp login page
	And  I have entered a valid emailaddress 
	And I have entered a invalid password
	When I press login
	Then I get an invalid credentials message 

@badrcpcode
Scenario: login to myrcp with invalid rcp cpde number
	Given I have navigated to the myrcp login page
	And  I have entered an invalid rcp code number 
	And I have entered a valid password
	When I press login
	Then I get an invalid credentials message 

@validcredentials
Scenario:login to myrcp with valid credentails
	Given I have navigated to the myrcp login page
	And  I have entered a valid emailaddress 
	And I have entered a valid password
	When I press login
	Then I get a "Welcome to myRCP" message on the top of the page 
