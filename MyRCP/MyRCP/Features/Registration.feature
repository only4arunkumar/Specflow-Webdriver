Feature: Registration
	In order to access my online benefits 
	As a user
	I want to be able to register  

@duplicatelogin
Scenario: Register with an existing email
	Given I have navigated to the "MY RCP" Registration page 
	And I have entered my details
	And my email address is already stored   
	When I press Create new account
	Then I am warned that I was unable to set up my account  
	
	
@InvalidInfo 
Scenario: Register with an incorrect email address
Given I have navigated to the "MY RCP" Registration page
And I have entered my details 
And The email address entered is not valid 
When I press Create new account
Then I am warned that I have entered an invalid email 


@Noemail 
Scenario: Register without entering an email
Given I have navigated to the "MY RCP" Registration page
And I have entered my details 
And I have not entered an email
When I press Create new account
Then I am warned that the email is required 


#@SuccesfulRegistration
#Scenario: Register with correct details 
#Given I have navigated to the "MY RCP" Registration page
#And I fill in the following:
#| Title | Firstname   | Lastname    | E-mailaddress     | Password | Confirm Password |
#| DR    | RCPFnameAut | RCPLnameAut | rcpautomationuser+ | password | password         |
#When I press Create new account
#Then A welcome email with further instuctions is sent  
# 

@SuccesfulActivation
Background: 





