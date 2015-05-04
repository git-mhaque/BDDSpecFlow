Feature: Simple Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the result of simple arithematics

	Scenario Outline: Subtract two numbers
	Given the first number is "<input1>"
	And the second number is "<input2>"
	When I use Subtract in the calculator
	Then the result should be "<output>"

	Examples: 
	| input1 | input2 | output |
	| 10     | 5      | 5      |
	| 20     | 13	  | 7      |
	| -1     | -2	  | 1      |
	| 10     | 51	  | -41    |

	Scenario Outline: Multiply two numbers
	Given the first number is "<input1>"
	And the second number is "<input2>"
	When I use Multiply in the calculator
	Then the result should be "<output>"

	Examples: 
	| input1 | input2 | output |
	| 10     | 5      | 50     |
	| 20     | 13	  | 260    |
	| -1     | -2	  | 2      |

