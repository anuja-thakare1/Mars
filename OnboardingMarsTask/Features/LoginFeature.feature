Feature: LoginFeature

As a user i want to login to the mars application so that i can update my profile with languages and skills i know.


Scenario: login with valid credentials
	Given User is navigated to mars applictions 
	When user enter username and password click login
	Then user must be logged in to the application
