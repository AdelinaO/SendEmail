Feature: Gmail login
In order to write an email
As a simple user
I want to send an email

Scenario Outline: Login to the gmail

  Given I navigated to Gmail page
  When  I choose Use another account option
  Then  I type the "<Adress>"
  And   I continue
  Then  I type again, the "<Password>"
  And   I keep continue
  Then  I should be logged in
  
   Examples: 

   | Adress                    |  Password                  |
   | Aeiou1690.                | oprea.adelina91@gmail.com  |
  
 
  
 