Feature: SL_Buying

As a registered user of the Sauce Labs website

I want to be able to add items to my basket

and then checkout

Background: Login
Given I am logged in

# Do not have to repeat ourselves in every scenario. The above steps do not have to repeated for s

@tag1
Scenario: Adding a single item to basket
	When I click to add the source labs back pack to my cart
	Then the basket counter should increase by 1
