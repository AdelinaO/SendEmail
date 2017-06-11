Feature: Gmail login

Scenario: Login to the gmail

  Given I navigated to gmail page
  When  I choose 'Use another account' option (#identifierLink > div.vdE7Oc.f3GIQ) (//*[@id="identifierLink"]/div[2] xpath)
  And   I type the email (#identifierId)(//*[@id="identifierId"] xpath)
  And   I execute the next button (#identifierNext > content > span)(//*[@id="identifierNext"]/content xpath)
  And   I type the password (#password > div.aCsJod.oJeWuf > div > div.Xb9hP > input)(//*[@id="password"]/div[1]/div/div[1]/input xpath)
  And   I execute the next button (#passwordNext > content)(//*[@id="passwordNext"]/content xpath)
  Then  I should be logged in --assert