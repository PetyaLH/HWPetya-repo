using HWDesignPatterns.Pages._2.NavigationsDragabblePage;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System.Collections.ObjectModel;


namespace HWDesignPatterns.Tests.InteractionsTests
{
    public class Draggable : BaseTest
    {
        private DraggablePage _draggablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Maximize();
            _draggablePage = new DraggablePage(Driver);
            _draggablePage.NavigateTo();
            _draggablePage.WaitPageToLoad();

            ReadOnlyCollection<IWebElement> interactionSection = _draggablePage.InteractionTable;
            interactionSection[4].Click();

            IWebElement scrlbottom = _draggablePage.ScrToSection;
            _draggablePage.ScrollTo(scrlbottom);

            ReadOnlyCollection<IWebElement> interaction = _draggablePage.InteractionList;
            interaction[4].Click();

        }
        [Test]
        public void DragBox_SimpleTab_LocationCheck()
        {

            //var draggableBox = _driver.FindElement(By.Id("dragBox"));
            double boXBefore = _draggablePage.DraggableBox.Location.X;
            double boYBefore = _draggablePage.DraggableBox.Location.Y;

            Builder
                .DragAndDropToOffset(_draggablePage.DraggableBox, 50, 70)
                .Release()
                .Perform();

            double boXAfter = _draggablePage.DraggableBox.Location.X;
            double boYAfter = _draggablePage.DraggableBox.Location.Y;

            Assert.AreEqual(353.0d, boXBefore, 3);
            Assert.AreEqual(294.0d, boYBefore, 3);

            Assert.AreEqual(403.0d, boXAfter, 3);
            Assert.AreEqual(364.0d, boYAfter, 3);

        }
        [Test]
        public void DragBox_ContainerRestrictionTab_CheckLocationWithinContainer()
        {

            _draggablePage.GoToContainerTab();

            double boxPosXBefore = _draggablePage.ContainedBox.Location.X;
            double boxPosYBefore = _draggablePage.ContainedBox.Location.Y;

            Builder
                .DragAndDropToOffset(_draggablePage.ContainedBox, 400, 0)
                .Release()
                .Perform();

            double boxPosXAfter = _draggablePage.ContainedBox.Location.X;
            double boxPosYAfter = _draggablePage.ContainedBox.Location.Y;

            Assert.AreEqual(373.0d, boxPosXBefore, 3);
            Assert.AreEqual(314.0d, boxPosYBefore, 3);

            Assert.AreEqual(748.0d, boxPosXAfter, 3);
            Assert.AreEqual(314.0d, boxPosYAfter, 3);

        }
        [Test]
        public void DragBox_AxisRestricted_LocationCheck()
        {
            _draggablePage.WaitToLoad();
            _draggablePage.GoToAxisRestrictedTab();//Clicks on the axisRestriction TAB

            double XBefore = _draggablePage.RestrictedX.Location.X;

            Builder
                .DragAndDropToOffset(_draggablePage.RestrictedX, 152, 0)
                .Perform();

            double XAfter = _draggablePage.RestrictedX.Location.X;
            Assert.AreNotEqual(XBefore, XAfter);

            double YBefore = _draggablePage.RestrictedY.Location.Y;

            Builder
                .DragAndDropToOffset(_draggablePage.RestrictedY, 0, 152)
                .Perform();

            double YAfter = _draggablePage.RestrictedY.Location.Y;
            Assert.AreNotEqual(YBefore, YAfter);
        }

        [TearDown]
        public void TearDown()
        {
            //if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            //{
            //    ITakesScreenshot screenshotDriver = (ITakesScreenshot)Driver;
            //    Screenshot screenshot = screenshotDriver.GetScreenshot();
            //    screenshot.SaveAsFile("testscrshot.bmp", ScreenshotImageFormat.Bmp);
            //}
            //Driver.Quit();
        }
    }
}
