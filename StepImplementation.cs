using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Microsoft.Playwright;


namespace netcore.template
{
    public class StepImplementation
    {
        private HashSet<char> _vowels;

        [Step("Start Chrome in thread")]
        public async void StartChromeInThread()
        {
            var t = Task.Run(async () =>
            {
                var playwright = Playwright.CreateAsync().Result;
                var browser = playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false }).Result;
                var page = browser.NewPageAsync().Result;
                await page.GotoAsync("http://www.google.com/");
            });
            t.Wait();
        }

        [Step("Start Chrome")]
        public void StartChrome()
        {
            var playwright = Playwright.CreateAsync().Result;
            var browser = playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false }).Result;
            var page = browser.NewPageAsync().Result;
            page.GotoAsync("http://www.google.com/");

        }
    }
}
