Feature: AddNumbers
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
Given I have cleared the calculator
When I enter 2
And I add 2
Then the result should be 4
