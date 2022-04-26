using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace herokuapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = new ChromeDriver();

            IJavaScriptExecutor Js = (IJavaScriptExecutor)Driver;


            Driver.Manage().Window.Maximize();


            
            //Add Remove

            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/add_remove_elements/");

            Driver.FindElement(By.XPath("//div//button[@onclick='addElement()']")).Click();
            Thread.Sleep(1000);

            Driver.FindElement(By.XPath("//div//button[@onclick='addElement()']")).Click();
            Thread.Sleep(1000);

            Driver.FindElement(By.XPath("//div//button[@onclick='addElement()']")).Click();
            Thread.Sleep(1000);

            Driver.FindElement(By.XPath("//div//button[@onclick='deleteElement()']")).Click();
            Thread.Sleep(1000);

            Driver.FindElement(By.XPath("//div//button[@onclick='deleteElement()']")).Click();
            Thread.Sleep(1000);

            Driver.FindElement(By.XPath("//div//button[@onclick='deleteElement()']")).Click();
            Thread.Sleep(2000);
            
            /*
            //Basic Authentication

            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/basic_auth");

            Driver.FindElement(By.XPath("//div//button[@onclick='addElement()']")).SendKeys("admin");

            Driver.FindElement(By.XPath("//div//button[@onclick='addElement()']")).SendKeys("admin");
            */

            //Challenging DOM

            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/challenging_dom");

            Driver.FindElement(By.XPath("//div//a[@href=''][1]")).Click();

            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div//a[@href=''][2]")).Click();

            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div//a[@href=''][3]")).Click();

            Thread.Sleep(2000);


            //Checkbox


            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/checkboxes");

            Driver.FindElement(By.XPath("//input[@type='checkbox'][1]")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//input[@type='checkbox'][1]")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//input[@type='checkbox'][2]")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//input[@type='checkbox'][2]")).Click();
            Thread.Sleep(2000);


            //Context Menu   

            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/context_menu");

            Actions actions = new Actions(Driver);
            WebElement elementLocator = (WebElement)Driver.FindElement(By.XPath("//div[@id='hot-spot']"));
            actions.ContextClick(elementLocator).Perform();
            Thread.Sleep(2000);
            
            /*
            //Dissapearing Elements

            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/disappearing_elements");
            Driver.FindElement(By.XPath("//a[@href='/about/']")).Click();
            Thread.Sleep(1000);

            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/disappearing_elements");
            Driver.FindElement(By.XPath("//a[@href='/contact-us/']")).Click();
            Thread.Sleep(1000);

            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/disappearing_elements");
            Driver.FindElement(By.XPath("//a[@href='/portfolio/']")).Click();
            Thread.Sleep(1000);

            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/disappearing_elements");
            Driver.FindElement(By.XPath("//a[@href='/gallery/']")).Click();
            Thread.Sleep(1000);
            
            */

            //Drag and Drop        

            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/drag_and_drop");

            Driver.SwitchTo().Alert().Dismiss();
            Thread.Sleep(2000);

            WebElement From1 = (WebElement)Driver.FindElement(By.XPath("//div[@id='column-a']"));            //from
            Thread.Sleep(1000);

            WebElement To1 = (WebElement)Driver.FindElement(By.XPath("//div[@id='column-b']"));              //to
            Thread.Sleep(1000);

            Actions act = new Actions(Driver);
            //act.DragAndDrop(From,To).Build().Perform();
            act.DragAndDrop(From1,To1).Build().Perform();
            Thread.Sleep(3000);


            //Dropdown    

            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dropdown");
            Driver.FindElement(By.XPath("//select[@id='dropdown']")).Click();
            Thread.Sleep(1000);

            Driver.FindElement(By.XPath("//select//option[@value='1']")).Click();
            Thread.Sleep(1000);

            Driver.FindElement(By.XPath("//select//option[@value='2']")).Click();
            Thread.Sleep(1000);
            



            //Dynamic Controls   

            //Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dynamic_controls");
            //Driver.FindElement(By.XPath("//button[@onclick="swapCheckbox()"]")).Click();




            //File Downloader     

            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/download");
            Driver.FindElement(By.XPath("//div//a[@href='download/some-file.txt']")).Click();
            Thread.Sleep(6000);
            Driver.FindElement(By.XPath("//div//a[@href='download/good_practice_2_0.png']")).Click();
            Thread.Sleep(6000);
            Driver.FindElement(By.XPath("//div//a[@href='download/sample.pdf']")).Click();
            Thread.Sleep(6000);
            Driver.FindElement(By.XPath("//div//a[@href='download/ObjectivityTestAutomationCSHarpFramework.txt']")).Click();
            Thread.Sleep(6000);


            

            //File Uploader            

            //Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/upload");

            //Driver.FindElement(By.XPath("//form//input[@id='file-upload']")).SendKeys(@"C:\Users\" + System.Environment. + @"SumitJha\Downloads\good_practice_2_0");

            //Thread.Sleep(2000);



            //Floating Menu

            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/floating_menu");
            Driver.FindElement(By.XPath("//li//a[@href='#news']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//li//a[@href='#contact']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//li//a[@href='#about']")).Click();
            Thread.Sleep(2000);

            //Forgot Password           

            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/forgot_password");
            Driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("abcd@gmail.com");
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//button[@id='form_submit']")).Click();
            Thread.Sleep(2000);


            // Login Page (Skip)

            //Hover         

            //Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/hovers");

            Actions Actions = new Actions(Driver);
            WebElement target = (WebElement)Driver.FindElement(By.XPath("//div//img[@alt='User Avatar']"));
            actions.MoveToElement(target).Perform();
            Thread.Sleep(2000);

            //Actions actions = new Actions(Driver);
            //IWebElement WebElement = Driver.FindElement(By.XPath("//div//img[@src='/img/avatar-blank.jpg']");

            //actions.MoveToElement("//div//img[@src='/img/avatar-blank.jpg'"]);




            //Infinite Scroll

            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/infinite_scroll");
            Js.ExecuteScript("window.scrollBy(0,1000)");
            Thread.Sleep(2000);
            Js.ExecuteScript("window.scrollBy(0,1000)");
            Thread.Sleep(2000);

            

            //Inputs     

            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/inputs");
            Driver.FindElement(By.XPath("//input[@type='number']")).SendKeys("7070759851");
            Thread.Sleep(2000);


            //JQueryUI-Menu

            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/jqueryui/menu#");
            Driver.FindElement(By.XPath("//a[@id='ui-id-2']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//a[@id='ui-id-4']")).Click();
            Thread.Sleep(2000);
            //Driver.FindElement(By.XPath("//a[@id='ui-id-6']")).Click();
            Thread.Sleep(2000);


            
            //  JS Alert         

            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/javascript_alerts");
            Driver.FindElement(By.XPath("//button[@onclick='jsAlert()']")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Alert().Dismiss();
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/javascript_alerts");
            Driver.FindElement(By.XPath("//button[@onclick='jsConfirm()']")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/javascript_alerts");
            Driver.FindElement(By.XPath("//button[@onclick='jsPrompt()']")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
            


            Driver.Close();
            Driver.Quit();


        }
    }
}
