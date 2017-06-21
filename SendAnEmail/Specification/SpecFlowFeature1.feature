Feature: Gmail login
In order to write an email
As a simple user
I want to send an email

Scenario Outline: Login to the gmail

  Given I navigated to Gmail page
  When  I choose 'Use another account' option
  And   I type the email adress "<oprea.adelina91@gmail.com>"
  
   Examples: 

   | Field        | Value                     |
   | email adress | oprea.adelina91@gmail.com |
  
  #I execute the next button     
  And   I continue
  And   I type the password

   Examples: 
  
   | Field        | Value                     |
   | password     | Aeiou1690.                |

  And   I keep continue
  Then  I should be logged in