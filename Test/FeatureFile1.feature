Feature: FeatureFile1
	In order to open a page
	As a user
	I want to open google page

@mytag
Scenario: Open google page
	Given I want to navigate to google
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen
