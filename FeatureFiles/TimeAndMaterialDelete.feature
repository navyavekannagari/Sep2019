Feature: TimeAndMaterialDelete
	In order to manage time and material as an admin
	I would like to create,edit,read and delete time and material records

@mytag
Scenario: delete a Time and Material 
	Given I have logged in to Turn up portal
	And I have navigated to time and material page 
	When I clicked on delete button
	Then I should be able to delete the data.
