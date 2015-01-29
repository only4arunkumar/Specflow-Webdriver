Feature: VerifyMandatoryDetails 
	In order to proceed with the membership wizard 
	As a user
	I will need to enter the mandatory personal information  

@ModifyDetails 
Scenario:  A user applies for an affiliate membership online
	Given I am logged in to the myRCP page
	And I am applying for affiliate membership 
	When I press Next on Step 2 of the membership wizard 
	Then I am prompted to enter an Address 

