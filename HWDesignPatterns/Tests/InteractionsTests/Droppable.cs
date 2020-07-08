using HWDesignPatterns.Pages._1.NavigationsDroppablePage;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.ObjectModel;


namespace HWDesignPatterns.Tests.InteractionsTests
{
    public class Droppable : BaseTest
    {
        private DroppablePage _droppablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Maximize();
            _droppablePage = new DroppablePage(Driver);
            _droppablePage.NavigateTo();
            _droppablePage.WaitPageToLoad();

            ReadOnlyCollection<IWebElement> interactionSection = _droppablePage.InteractionTable;
            interactionSection[4].Click();

            IWebElement scrlbottom = _droppablePage.ScrToSection;
            _droppablePage.ScrollTo(scrlbottom);


            ReadOnlyCollection<IWebElement> interaction = _droppablePage.InteractionList;
            interaction[3].Click();
        }
        [Test]
        public void DragDrop_SimpleTab_ChecksColorChange()
        {

            Builder.DragAndDrop(_droppablePage.DraggableBox, _droppablePage.DroppableBox)
                .Perform();

            _droppablePage.Assert_colorBeforeAndAfterAreNotEqual();

        }
        [Test]
        public void DragDrop_SimpleTab_ChecksTextChange()
        {

            Builder.DragAndDrop(_droppablePage.DraggableBox, _droppablePage.DroppableBox)
                .Perform();

            var textAfterDrop = _droppablePage.DroppableBox.Text;

            Assert.AreEqual("Dropped!", textAfterDrop);


        }
        [Test]
        public void DragDrop_SimpleTab_ChecksDragBoxIsOutsideDroppableBox()
        {

            _droppablePage.Assert_LocationDroppableBoxBefore();

            Builder
            .MoveToElement(_droppablePage.DraggableBox)
            .ClickAndHold()
            .MoveByOffset(500, 150)
            .Perform();

            _droppablePage.Assert_LocationDroppableBoxAfter();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
