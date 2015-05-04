Feature: HelloWorld
	In order to feel happy 
	As a user 
	I want to receive a friendly greeting

Scenario: Say Hello
	Given I have entered my name "Mahfuzul"
	When I press Say Hello
	Then The screen displays "Hello Mahfuzul!"
