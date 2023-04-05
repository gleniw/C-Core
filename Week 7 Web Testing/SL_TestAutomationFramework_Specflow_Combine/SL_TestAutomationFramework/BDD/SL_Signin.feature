Feature: SL_Signin

In order to be able to buy items
As a registered user of the Sauce Labs website 
I want to be able to sign in to my account

@Signin
@Happy

Scenario: Login with valid email and valid password
Given I am on the home page 
And I have entered a valid e-mail
And I have entered a valid password
When I click the login button 
Then I should land on the invetory page


@Signin
@Sad

Scenario: Login with valid email and invalid password
Given I am on the home page
And I have entered a valid e-mail
And I have entered a invalid password of "<passwords>"
When I click the login button
Then I should see an error message that contains "Epic sadface"
Examples: 
| passwords |
| wrong     |
| 12345     |
| Nishy     |

#Build before defining steps - Defining steps - Right Click
#Signin test page is now obsolete