using EasyAutomationFramework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using org.junit.@internal.matchers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WhatsAppBotProject
{
    public class WhatsappBot : Web
    {
        public void SendMessage(string message, string quantity, List<string> contactsList)
        {
            int intQuantity = int.Parse(quantity);
            int count = 0;

            string caminho = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Google\\Chrome\\User Data");

            StartBrowser(TypeDriver.GoogleChorme, caminho);

            Navigate("https://web.whatsapp.com/");

            WaitForLoad();

            WaitForElement(TypeElement.Xpath, "//*[@class='to2l77zo gfz4du6o ag5g9lrv bze30y65 kao4egtt qh0vvdkp']", 60);

            foreach (var to in contactsList)
            {
                var elementSearch = AssignValue(TypeElement.Xpath, "//*[@class='to2l77zo gfz4du6o ag5g9lrv bze30y65 kao4egtt qh0vvdkp']", to);

                elementSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);

                while (count < intQuantity)
                {
                    elementSearch.element.Clear();

                    var elementMessage = AssignValue(TypeElement.Xpath, "//*[@class='to2l77zo gfz4du6o ag5g9lrv bze30y65 kao4egtt']", message);

                    elementMessage.element.SendKeys(OpenQA.Selenium.Keys.Enter);
                    count++;
                }
                count = 0;
            }
        }

        public void StopProcess()
        {
            CloseBrowser();
        }
    }
}
