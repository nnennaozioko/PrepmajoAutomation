Feature: Search
	As a user of prepmajor
	I want to serach
	so I register for a course


@mytag
Scenario: Search for a course
	Given I navigate to "https://wwww.prepmajor.com"
	When I clicked on the search field
	And I type "automation" in the search feild
	And I click the search button
	Then the result page should display