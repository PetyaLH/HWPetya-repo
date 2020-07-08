using NUnit.Framework;


namespace HWDesignPatterns.Pages._1.NavigationsDroppablePage
{
    public partial class DroppablePage : BasePage
    {
        public void Assert_LocationDroppableBoxBefore()
        {
            Assert.AreEqual(445.0d, DraggableBox.Location.X, 3);
            Assert.AreEqual(302.0d, DraggableBox.Location.Y, 3);
        }
        public void Assert_LocationDroppableBoxAfter()
        {
            Assert.AreEqual(945.0d, DraggableBox.Location.X, 3);
            Assert.AreEqual(452.0d, DraggableBox.Location.Y, 3);
        }

        public void Assert_colorBeforeAndAfterAreNotEqual()
        {
            Assert.AreNotEqual(DroppableBox.GetCssValue("color"), DroppableBox.GetAttribute("background-color"));
        }
    }
}
