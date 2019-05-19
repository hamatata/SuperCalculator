Feature: CalculatorFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have also entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

#Scenario: Add two numbers
#	Given I have entered <Operand1> into the calculator
#	And I have also entered <Operand2> into the calculator
#	When I press add
#	Then the result should be <Result> on the screen
#	| Operand1 | Operand2 | Result |
#	| 20 | 50 | 70  |
#	| 30 | -10  | 20  |
#	| 156 | 1 | 157 |
