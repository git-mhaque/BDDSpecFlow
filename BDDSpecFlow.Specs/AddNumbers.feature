Feature: AddNumbers
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 150 into the calculator
	And I have entered 170 into the calculator
	When I press add
	Then the result should be 320 on the screen
