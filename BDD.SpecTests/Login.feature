Feature: Register
		As an user 	I  can register  an account so that I can use the Blog system

		Scenario Outline:  New Register
		Given I have navigated to the register page
		And I have filled in my '<EmailAddress>' into the email field
		And I have not registered with my email address '<EmailAddress>' before
		And I have filled in my '<Password>' into the password field

		When I click the register button

		Then I see the  '<confirmation-message>'				

		Examples: 
		| EmailAddress         | Password | confirmation-message |
		| wangdeshui@gmail.com | 123abc   |Thank you for registering |


	


