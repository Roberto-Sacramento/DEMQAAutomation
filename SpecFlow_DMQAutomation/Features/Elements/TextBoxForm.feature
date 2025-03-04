Feature: TextBoxForm

A short summary of the feature


Scenario: Fill in Text Box form
	Given I navigate to the main page
	When I navigate to Elements page
	When I fill in the Text Box form with Sacramento, sacra@gmail.com, Sky street, 1234567890
	Then I should see the Text area filled 
