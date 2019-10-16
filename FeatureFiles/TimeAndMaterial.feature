Feature: TimeAndMaterial
	in order to manage time and material as an admin
	i would like to create, edit,read and delete time and material records
@mytag
Scenario: Craete a Time record with valid inputs.
	Given I have logged in to Turnup portal.
	And I have Navigated to Time and Material page.
	Then I should be able to create a time record succesfully.
