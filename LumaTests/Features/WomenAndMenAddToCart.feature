﻿Feature: Add product from category 'Women' and 'Men' to cart

A short summary of the feature

@tag1
Scenario Outline: As a User I enter a product page, choose size, color, and qty, and click on Add to Cart, next, I can confirm that the product is added correctly to the cart 	
	Given I enter to home page
	And From the menu, I select a "<section>"
	And I click on "<category>"
	And I choose "<product name>"
	And I select "<size>", "<color>" and "<quantity>"
	And I add product to cart
	Then I can see a message about adding a "<product name>" to the basket
	And I go to the shopping cart by clicking cart icon
	And I can see that "<size>", "<color>" and "<quantity>" of the product are correct 


	Examples: 
	| section | category | product name        | size | color  | quantity |
	| Women   | Tees     | Layla Tee           | M    | Green  | 4        |
	| Men     | Pants    | Caesar Warm-Up Pant | 36   | Purple | 1        |

	
