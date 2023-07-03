Feature: Add product from category 'What's New' and 'Sale' to cart

A short summary of the feature

@tag1
Scenario Outline: As a User I enter What's New or Sale section, then I choose category and enter product page, choose size, color, and qty, and click on Add to Cart, next, I can confirm that the product is added correctly to the cart 	
	Given I am on home page
	And From the menu, I choose a "<section>"
	And I enter "<category>"
	And I click "<product name>"
	And Then I choose "<size>", "<color>" and "<quantity>"
	And I click on 'Add to cart'
	Then I can see a message about adding a "<product name>" to the cart
	And I enter the shopping cart by clicking cart icon
	And I check if "<size>", "<color>" and "<quantity>" of the product are correct 


	Examples: 
	| section		| category | product name        | size | color  | quantity |
	| What's New    | Women's Jackets | Circe Hooded Ice Fleece  | M    | Green  | 4        |
	
	 
