using HWDesignPatterns.Pages._3.NavigationsResizablePage;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.ObjectModel;


namespace HWDesignPatterns.Tests.InteractionsTests
{
    public class Resizable : BaseTest
    {
        private ResizablePage _resizablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Maximize();
            _resizablePage = new ResizablePage(Driver);
            _resizablePage.NavigateTo();
            _resizablePage.WaitPageToLoad();

            ReadOnlyCollection<IWebElement> interactionSection = _resizablePage.InteractionTable;
            interactionSection[4].Click();

            IWebElement scrlbottom = _resizablePage.ScrToSection;
            _resizablePage.ScrollTo(scrlbottom);


            ReadOnlyCollection<IWebElement> interaction = _resizablePage.InteractionList;
            interaction[2].Click();
        }

        [Test]
        public void ResizableBoxWithRestriction()
        {

            Builder
            .DragAndDropToOffset(_resizablePage.Handle, 300, 100)
            .Perform();

            var finalBoxSize = _resizablePage.ResizableBoxWithRestrictions.Size; //takes the Size of the box after draging

            //asserts that the box is resized within the constraint area
            Assert.AreEqual(_resizablePage.ConstraintArea.Size, finalBoxSize);
        }

        [Test]
        public void ResizableBox()
        {

            var initialBoxSize = _resizablePage.ResizableBox.Size; //takes tha initial size of the box


            _resizablePage.ScrollTo(_resizablePage.Handle2);

            Builder
            .DragAndDropToOffset(_resizablePage.Handle2, 500, 200)
            .Perform();

            var finalBoxSize = _resizablePage.ResizableBox.Size; //takes the Size of the box after draging 

            //asserts that the initial and final Size are not equal
            Assert.AreNotEqual(initialBoxSize, finalBoxSize);

        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
