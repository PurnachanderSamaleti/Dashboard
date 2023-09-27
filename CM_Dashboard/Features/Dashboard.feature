Feature: Dashboard

Test the Dashboard page

Background:
	Given Enter a valid username
	When enter a valid password
	And click on keep me sign in button
	Then click on Sign in button

Scenario: Test the Select group component
	Given Select the "Simmental Dairy" company from the company list page
	When Click on the Dashboar component
	When Click on the select group dropdown
	When Click on the Hyd East5 dropdown
	And click on the Rescows group checkbox
	And Click on the Location 2 dropdown
	And Enable the 3 and 4 checkboxes
	And Click on the chandu checkbox
	And Click on the Select all checkbox
	Then Again click on the select group dropdown
