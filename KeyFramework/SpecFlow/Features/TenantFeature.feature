Feature: TenantFeature
	
@Smoke
Scenario: Verify AddNew Tenant
	#Given Navigate to the login page
	#And  I have enter 'vincent.nguyen@mvpstudio.co.nz' and  'ntmv2682'
	#And I click on Login button
	Then I should see property dashboard page
	And  I click Add Tenant link on application
	When I fill mandatory details on the add tenant forms
	| Key           | Value          |
	| TenantEmail   | tt@gmail.com | 
	| FirstName     | bincy          |
	| LastName      | savio          |
	| RentStartDate | 05/04/2018     |
	| RentAmount    | 350            |
	| PaymentSDate  | 06/04/2018     |
	And I click the NEXT button
	Then I should see all the details should saved and Liabilities detail page opened
	When I click on Add New Liability button
	And I have enter amount on add new liability application
	And  I click on Next button 
	Then I should see all the details saved and page redirected to summary page.
	When I click on submit button on summary page
	Then I should see all data should be saved and application redirect to properties page.



