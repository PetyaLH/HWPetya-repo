using HWDesignPatterns.Pages._3.NavigationsResizablePage;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System.IO;

namespace HWDesignPatterns.Tests.InteractionsTests
{
    public class Sortable : BaseTest
    {
        private SortablePage _sortablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Maximize();
            _sortablePage = new SortablePage(Driver);
            _sortablePage.NavigateTo();
            _sortablePage.WaitPageToLoad();

            ReadOnlyCollection<IWebElement> interactionSection = _sortablePage.InteractionTable;
            interactionSection[4].Click();

            IWebElement scrlbottom = _sortablePage.ScrToSection;
            _sortablePage.ScrollTo(scrlbottom);


            ReadOnlyCollection<IWebElement> interaction = _sortablePage.InteractionList;
            interaction[0].Click();
        }
        [Test]
        public void SwitchElements_ListTab_AssertText()
        {

            Builder //swaps the first and the second box
                .ClickAndHold(_sortablePage.FirstElement)
                .MoveToElement(_sortablePage.SecondElement)
                .Release()
                .Perform();

            //asserts the text of the first box that have changed
            Assert.AreNotEqual("One", _sortablePage.FirstElement.Text);
            Assert.AreEqual("Two", _sortablePage.FirstElement.Text);
        }

        [Test]
        public void SwitchElements_FromGridTab_AssertText()
        {

            _sortablePage.NavigateToGrid();

            Builder //swaps the first and the fifth box
                .ClickAndHold(_sortablePage.ElementOne)
                .MoveToElement(_sortablePage.ElementFive)
                .Release()
                .Perform();

            _sortablePage.WaitToLoad();

            //asserts the text of the first box that have changed
            Assert.AreNotEqual("One", _sortablePage.ElementOne.Text);
            Assert.AreEqual("Two", _sortablePage.ElementOne.Text);

        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                ITakesScreenshot screenshotDriver = (ITakesScreenshot)Driver;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile($"{Directory.GetCurrentDirectory()}/{TestContext.CurrentContext.Test.Name}.png", ScreenshotImageFormat.Png);
            }
            Driver.Quit();
        }
    }
}
