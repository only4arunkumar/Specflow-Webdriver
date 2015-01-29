Feature: ModifyContactDetails
	In order to modify my details online 
	As a user
	I want to be able to login to myrcp page  

@ModifyDetails 
Scenario:  A user modifies their details online
	Given I have succesfully logged in to the myRCP page
	And I have pressed Update my details 
	And I modify my first name 
	When I press Save your details
	Then I am redirected to the main dashboard
	And I get a messages at the top of the page confirming the changes  
