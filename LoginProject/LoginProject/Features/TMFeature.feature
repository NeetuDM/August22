Feature: TMFeature1

A short summary of the feature

@tag1
Scenario: Create time and material record with valid details
	Given I logged into turn up portal successfully
	When I navigate to the time and material page
	And I create a new time and material record
	Then The record should be create successfully

 Scenario Outline: Edit time and material record with valid details
    Given I logged into turn up portal successfully
	When I navigate to the time and material page
	And I update '<Description>', '<Code>' and '<Price>' on an existing time and material record
	Then The record should have the updated '<Description>', '<Code>' and '<Price>'

	Examples: 
	| Description | Code     | Price    |
	| abc         | Neetu    | $5,000.00 |
	| Material    | Keyboard | $100.00  |
	| Updated     | Mouse    | $1,500.00 |