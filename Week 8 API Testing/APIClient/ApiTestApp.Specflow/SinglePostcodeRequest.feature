Feature: SinglePostcodeRequest

In order to get the details of a postcode
As a user 
I want to be able to make a request for a single postcode on postcodes.io

Background: 
Given I have initialized the SinglePostcodeService

@Happy
Scenario: Request for a valid postcode returns valid status code in response header and JSON response body
	When I make a request for the postcode "EC2Y 5AS"
	Then Status in the JSON response body should be 200
	And the status header should be 200

@Happy
Scenario: Request for a valid postcode returns a JSON response body with the correct schema
	When I make a request for the postcode "EC2Y 5AS"
	Then The JSON Response body should match the JSON Schema in "SucessfulSinglePostcodeResponse.json"
