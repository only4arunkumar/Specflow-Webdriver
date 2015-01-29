Feature: Logout
	In order to keep my personal information secure
	As a user
	I want to logout of MyRCP 

@logout
Scenario: user wants to logout from the "MyRCP" page 
	Given I am succesfully logged-in to the "MyRCP" page  
	When I press logout
	Then I am redirected to the Rcp London home page
