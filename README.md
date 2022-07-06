# Senukai.lt page testing project

## Setup

### Packages used:

#### Framework
- Selenium.Support
- Selenium.WebDriver
- Selenium.WebDriver.ChromeDriver (different browser might be used)
- DotNetSeleniumExtras.WaitHelpers (for ExpectedConditions class)

#### Tests
- Microsoft.NET.Test.Sdk
- NUnit
- NUnit3TestAdapter
- Selenium.WebDriver.ChromeDriver

### Site used for testing
#### https://www.senukai.lt

### Pages used for testing

1.[Add to basket](https://www.senukai.lt/p/baseinas-intex-28242np-melynas-4570x1220-mm-16805-l/ah6m?mtd=top&pos=top&src=bitrec&index=1).
2.[Buy without registration](https://www.senukai.lt/checkout_authentication/new).
3.[Login](https://www.senukai.lt/users/sign_in).
4.[Registration](https://www.senukai.lt/users/sign_up).
5.[Search](https://www.senukai.lt).

##1.Test used for Add item to basket

- Open https://www.senukai.lt/p/baseinas-intex-28242np-melynas-4570x1220-mm-16805-l/ah6m?mtd=top&pos=top&src=bitrec&index=1
- Select quantity and increase by 1
- Click on "put in the basket" button
- Read the text message
- Check the result

##2.Test used for Buying without registration

- Open https://www.senukai.lt/checkout_authentication/new
- Enter buyer email
- Click on "continue" button
- Read the result
- Check the result


##3.Test used for user login with a wrong password and email

- Open https://www.senukai.lt/p/baseinas-intex-28242np-melynas-4570x1220-mm-16805-l/ah6m?mtd=top&pos=top&src=bitrec&index=1
- Enter username
- Enter usser password
- Click on "submit" button
- Read the message
- Take a screenshot
- Check the result



##4. Test used for registration page with wrong format email

- Open https://www.senukai.lt/users/sign_up
- Enter username
- Enter surname
- Enter user email
- Enter user password
- Enter usser password in repeat password input field
- Click on "registration" button
- Read the message
- Take a screenshot
- Check the result


##5. Test used for search field

- Open https://www.senukai.lt
- In search field enter searching item
- Click on search button
- Wait for element to be visible
- Read the message
- Check the result
