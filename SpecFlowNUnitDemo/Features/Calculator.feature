Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

@mytag
Scenario: Subtract two numbers
	Given I have entered 70 into the calculator
	And I have entered 50 into the calculator
	When I press subtract
	Then the result should be 20 on the screen

Scenario Outline: Divide two numbers
	Given I have entered <ValueOne> into the calculator
	And I have entered <ValueTwo> into the calculator
	When I press divide
	Then the result should be <Result> on the screen
Scenarios: 
		| ValueOne | ValueTwo | Result |
		| 100      | 2        | 50     |
#  check floats
		| 4.5      | 2        | 2.25   |   
# check negatives
		| 100       | -2       | -50    |     
#		| 5       | 0       | fail     |