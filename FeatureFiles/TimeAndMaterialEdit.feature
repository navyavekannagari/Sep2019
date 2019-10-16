Feature: In Order to manage time and material as an admin
I would like to create ,edit, read and delete time and material records.

@mytag
Scenario: Edit Time record with valid data
	Given i have logged to TurnUp portal
	And and Navigated to Time and Material page
	When i clicked on edit the data and fill the valud data
	Then i should be able to save the edited data.
