Feature: Forms

    Scenario: Create a registrattion for male studant
        Given I navigate to the main page
        When I fill the Form fields with the following data:
            | Field            | Value                 |
            | firstName        | Alex                  |
            | lastName         | Poatan                |
            | userEmail        | poatanchama@gmail.com |
            | userNumber       | 01299852544           |
            | subjectsInput    | English               |
            | currentAddress   | Las Vegas             |
            | dateOfBirthInput | 12 Apr 2020           |
        Then The system should display a modal with a confirmation message