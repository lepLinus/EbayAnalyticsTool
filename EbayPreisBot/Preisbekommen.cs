using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using Microsoft.WindowsAPICodePack.Taskbar;

namespace EbayPreisBot
{
    class Preisbekommen
    {
        public string search;
        public enum driverAvailable { Google_Chrome, Mozilla_Firefox };
        public driverAvailable driverSelected;
        public List<double> prices = new List<double>();
        public List<string> links = new List<string>();
        public IList<IWebElement> list;
        public IList<IWebElement> linklist;
        public bool end;

        //Ebay-EbayKleinanzeigen
        public string platform;
        //Driver
        public ChromeDriver cDriver;
        public FirefoxDriver fDriver;

        //Output
        public double sum = 0;
        public double max = 0;
        public double min = 1000000;

        // [Test]
        public void Test(Form1 frm)
        {
            //Initialize
            end = false;
            prices.Clear();
            links.Clear();
            try
            {
                //Check for selected Browser
                if (driverSelected == driverAvailable.Google_Chrome)
                {
                    //Chrome Options
                    ChromeOptions optionsChrome = new ChromeOptions();
                    optionsChrome.AddArgument("--window-size=400,400");

                    //Chrome Driver Setup
                    cDriver = new ChromeDriver(Directory.GetCurrentDirectory(), optionsChrome);
                    cDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                    cDriver.Url = "https://www.ebay.de/";
                    cDriver.FindElement(By.Name("_nkw")).SendKeys(search);
                    cDriver.FindElement(By.Id("gh-btn")).Click();

                    string url = cDriver.Url;
                    url += "&LH_BIN=1";
                    cDriver.Url = url;

                    //Get Prices
                    while (end == false)
                    {
                        frm.ResetProgress();
                        list = cDriver.FindElements(By.ClassName("s-item__price"));
                        linklist = cDriver.FindElements(By.ClassName("s-item__link"));

                        for (int i = 0; i < list.Count(); i++)
                        {
                            IWebElement el = list[i];
                            prices.Add(GetPrizeAsFloat(el.Text));
                            frm.AddProgress(list.Count);
                        }
                        for (int i = 0; i < linklist.Count(); i++)
                        {
                            links.Add(linklist[i].GetAttribute("href"));
                        }
                        try
                        {
                            if (cDriver.FindElement(By.ClassName("pagination__next")).GetAttribute("aria-disabled") == "true")
                            {
                                end = true;
                            }
                            else
                            {
                                cDriver.FindElement(By.ClassName("pagination__next")).Click();
                            }
                        }
                        catch (Exception)
                        {
                            end = true;
                        }
                    }
                }
                else if (driverSelected == driverAvailable.Mozilla_Firefox)
                {
                    //Firefox Options
                    FirefoxOptions optionsFirefox = new FirefoxOptions();
                    optionsFirefox.AddArguments("--window-size=400,400");
                    optionsFirefox.AddArgument("--headless");

                    //Firefox Drivers
                    fDriver = new FirefoxDriver(Directory.GetCurrentDirectory(), optionsFirefox);
                    fDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                    fDriver.Url = "https://www.ebay.de/";
                    fDriver.FindElement(By.Name("_nkw")).SendKeys(search);
                    fDriver.FindElement(By.Id("gh-btn")).Click();

                    string url = fDriver.Url;
                    url += "&LH_BIN=1";
                    fDriver.Url = url;

                    //Get Prices
                    while (end == false)
                    {
                        frm.ResetProgress();
                        list = fDriver.FindElements(By.ClassName("s-item__price"));
                        linklist = fDriver.FindElements(By.ClassName("s-item__link"));

                        for (int i = 0; i < list.Count(); i++)
                        {
                            IWebElement el = list[i];
                            prices.Add(GetPrizeAsFloat(el.Text));
                            frm.AddProgress(list.Count);
                        }
                        for (int i = 0; i < linklist.Count(); i++)
                        {
                            links.Add(linklist[i].GetAttribute("href"));
                        }
                        try
                        {
                            if (fDriver.FindElement(By.ClassName("pagination__next")).GetAttribute("aria-disabled") == "true")
                            {
                                end = true;
                            }
                            else
                            {
                                fDriver.FindElement(By.ClassName("pagination__next")).Click();
                            }
                        }
                        catch (Exception)
                        {
                            end = true;
                        }
                    }
                }

                sum = 0;
                max = 0;
                min = 1000000;

                //Calculate results
                for (int i = 0; i < prices.Count; i++)
                {
                    if (i > 0)
                    {
                        if (prices[i] > max)
                        {
                            max = prices[i];
                        }
                        if (prices[i] < min)
                        {
                            min = prices[i];
                        }
                    }
                    sum += prices[i];
                }

                //Output
                Console.WriteLine("The AVG price is : " + (int)(sum / prices.Count()));
                Console.WriteLine("The Min price is : " + min);
                Console.WriteLine("The Max price is : " + max);
                Console.WriteLine("The amount of offers is: " + prices.Count());
                frm.ResetProgress();
            }
            catch (Exception)
            {
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error);
            }
            //Close Browser
            if (driverSelected == driverAvailable.Google_Chrome)
            {
                cDriver.Close();
                cDriver.Quit();
            }
            else if (driverSelected == driverAvailable.Mozilla_Firefox)
            {
                fDriver.Close();
                fDriver.Quit();
            }
        }

        public double GetPrizeAsFloat(string input)
        {
            string[] splited = input.Split(' ');
            for (int i = 0; i < splited.Length; i++)
            {
                try
                {
                    double result = Convert.ToDouble(splited[i]);
                    //float.TryParse(splited[i], NumberStyles.Any, CultureInfo.InvariantCulture, out result);
                    return result;
                }
                catch (Exception) { }
            }
            return 0;
        }
    }
}
