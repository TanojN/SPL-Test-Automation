using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SPL.UnitTest
{
    public class VerifyProductInfo
    {

        [Fact]
        public void VerifyLogin()
        {
            //Arrange test
            IWebDriver driver = null;
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://channel.dell.com/spl/products/";
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(10);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementExists(By.Id("spl-product-title")));

            driver.FindElement(By.ClassName("spl-signin-icon-label")).Click();
            wait.Until(ExpectedConditions.ElementExists(By.Id("sign-in-button")));
            IWebElement username = driver.FindElement(By.Id("EmailAddress"));
            IWebElement password = driver.FindElement(By.Id("Password"));
            IWebElement signIn = driver.FindElement(By.Id("sign-in-button"));
            username.SendKeys("Tanoj_k@dellteam.com");
            password.SendKeys("12345678");
            signIn.Click();

            IWebElement productTitle = driver.FindElement(By.Id("spl-product-title"));
            // wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            fluentWait.Timeout = TimeSpan.FromSeconds(10);
            productTitle.Click();
            wait.Until(ExpectedConditions.ElementExists(By.Id("spl_associated_products_tab")));
            // wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            fluentWait.Timeout = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("spl_associated_products_tab")).Click();
            fluentWait.Timeout = TimeSpan.FromSeconds(10);





            //IWebElement findLogin = driver.FindElement(By.ClassName("spl-signin-icon-label"));
            //findLogin.Click();

            //  driver.FindElement(By.XPath("//a[contains(.,' Memory Cards ')]")).Click();

            // string findDivText = driver.FindElement(By.XPath("//div[contains(.,'724YX')]")).ToString();

            // IWebElement findTextLocal = driver.FindElement(By.XPath("//span[text()='724YX']"));
            //findTextLocal.Click();

            //  driver.FindElement(By.LinkText("1Y Mail-in to 4Y ProSpt Plus")).Click();

            //driver.FindElement(By.XPath("//a[contains(.,'1Y Mail-in to 4Y ProSpt Plus')]")).Click();



            //Assert test
            // Assert.Equal(findDivText, "724YX");
            // driver.Close();
        }


        [Fact]
        public void VerifyLoginFeatured()
        {
            //Arrange test
            IWebDriver driver = null;
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://dell-channel-spl-frontend-prod.s2.pcf.dell.com/spl/products?c=ca&l=en&r=ca";
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(10);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementExists(By.Id("productTitle")));

            driver.FindElement(By.Id("log-in")).Click();
            wait.Until(ExpectedConditions.ElementExists(By.Id("sign-in-button")));
            IWebElement username = driver.FindElement(By.Id("EmailAddress"));
            IWebElement password = driver.FindElement(By.Id("Password"));
            IWebElement signIn = driver.FindElement(By.Id("sign-in-button"));
            username.SendKeys("Tanoj_k@dellteam.com");
            password.SendKeys("12345678");
            signIn.Click();

            IWebElement productTitle = driver.FindElement(By.Id("spl-product-title"));
            // wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            fluentWait.Timeout = TimeSpan.FromSeconds(10);
            productTitle.Click();
            wait.Until(ExpectedConditions.ElementExists(By.Id("spl_associated_products_tab")));
            // wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            fluentWait.Timeout = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("spl_associated_products_tab")).Click();
            fluentWait.Timeout = TimeSpan.FromSeconds(10);
           
        }


        [Fact]
        public void VerifyProduct()
        {
            //Arrange test
            //https://dell-channel-spl-frontend-prod.s2.pcf.dell.com/spl/products?c=ca&l=en&r=ca
            IWebDriver driver = null;
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://channel.dell.com/spl/products/";
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(10);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementExists(By.Id("spl-product-title")));
            IWebElement productTitle = driver.FindElement(By.Id("spl-product-title"));
            fluentWait.Timeout = TimeSpan.FromSeconds(10);
            productTitle.Click();
            wait.Until(ExpectedConditions.ElementExists(By.Id("spl_associated_products_tab")));
            fluentWait.Timeout = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("spl_associated_products_tab")).Click();
            fluentWait.Timeout = TimeSpan.FromSeconds(10);
            //Assert test
            // Assert.Equal(findDivText, "724YX");
            // driver.Close();
        }
    }
}
