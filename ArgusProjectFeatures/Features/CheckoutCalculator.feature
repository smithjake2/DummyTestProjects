Feature: CheckoutCalculator

A short summary of the feature

#Overall Assumptions: The functionality does not require the bill to be calculated on a per person basis
Rule: Scenario 2 tested
@Scenario1 @Scenario3
Scenario: Starters, Mains and Drinks after cutoff
Given "4" starters are ordered
Given "4" mains are ordered
Given "4" drinks are ordered after the cutoff period
When The total bill is calculated
Then The total returned should be "59.40"
#[(4*4) + (4*7) + (4*2.50)] * 1.1
#Assumption: Scenario 1 and 3 unclear whether the drinks are before or after 19:00. Assumed it is after and discount is not applied

Rule: Scenario 2 tested
@Scenario2
Scenario: Starters, Mains and Drinks before cutoff
Given "1" starter is ordered
Given "2" mains are ordered
Given "2" drinks are ordered before the cutoff period
When The total bill is calculated
Then The total returned should be "23.65"
#[(1*4) + (2*7) + (2*(2.50 * 0.7))] * 1.1

Rule: Scenario 2 tested
@Scenario2
Scenario: Starters, Mains and Drinks before and after cutoff
Given "1" starter is ordered
Given "2" mains are ordered
Given "2" drinks are ordered before the cutoff period
Given "2" mains are ordered
Given "2" drinks are ordered after the cutoff period
When The total bill is calculated
Then The total returned should be "44.55"
#[(1*4) + (4*7) + (2*(2.50 * 0.7)) + (2*2.50)] * 1.1
#Assumption: The bill from the original orders (1S,2M,2PCD) are not cleared from the bill


Rule: Scenario 3 tested
@Scenario3
Scenario: Starters, Mains and Drinks removed
Given "4" starters are ordered
Given "4" mains are ordered
Given "4" drinks are ordered after the cutoff period
When "1" starter is removed
When "1" main is removed
When "1" drink from after the cutoff period is removed
When The total bill is calculated
Then The total returned should be "44.55"
#[(3*4) + (3*7) + (3*2.50)] * 1.1
#Assumption: Scenario 3 unclear whether the drinks are before or after 19:00. Assumed it is after and discount is not applied