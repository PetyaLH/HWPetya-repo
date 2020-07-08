using HWDesignPatterns.Pages._3.NavigationsResizablePage;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.ObjectModel;


namespace HWDesignPatterns.Tests.InteractionsTests
{
    public class Selectable : BaseTest
    {
        private SelectablePage _selectablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Maximize();
            _selectablePage = new SelectablePage(Driver);
            _selectablePage.NavigateTo();
            _selectablePage.WaitPageToLoad();

            ReadOnlyCollection<IWebElement> interactionSection = _selectablePage.InteractionTable;
            interactionSection[4].Click();

            IWebElement scrlbottom = _selectablePage.ScrToSection;
            _selectablePage.ScrollTo(scrlbottom);


            ReadOnlyCollection<IWebElement> interaction = _selectablePage.InteractionList;
            interaction[1].Click();
            _selectablePage.WaitToLoad();
        }
        [Test]
        public void SelectElement_FromListTab_AssertColors()
        {

            var colorBefore = _selectablePage.FirstElement.GetCssValue("color");

            _selectablePage.SelectFirstElement();

            _selectablePage.WaitToLoad();

            var colorAfter = _selectablePage.FirstElement.GetCssValue("color");

            //asserts that the color have changed
            Assert.AreNotEqual(colorBefore, colorAfter);


        }
        [Test]
        public void SelectElement_FromGridTab_AssertColors()
        {

            _selectablePage.NavigateToSelectableGridTab();

            _selectablePage.SelectFifthElement();

            var colorAfter = _selectablePage.BoxFive.GetCssValue("color");

            //asserts that the color have changed
            Assert.AreEqual("rgba(255, 255, 255, 1)", colorAfter);

        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
