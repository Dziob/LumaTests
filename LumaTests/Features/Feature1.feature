Feature: Add product to cart

A short summary of the feature

@tag1
Scenario: As a User I enter a product page, choose size, color, and qty, and click on Add to Cart, next, I can confirm that the product is added correctly to the cart 	
	Given I enter to home page
	And I click on Women
	And I click on Jackets
	And I choose Juno Jacket
	And I choose 'S' size, 'green' color and quantity '2'
	And I add product to cart
	Then I can see a message about adding a product to the basket
	And I can see that product in the cart is correct 
