using OpenQA.Selenium;


namespace HWDesignPatterns.Pages._1.NavigationsDroppablePage
{
    public partial class DroppablePage : BasePage
    {
        public IWebElement DraggableBox => Driver.FindElement(By.Id("draggable"));

        public IWebElement DroppableBox => Driver.FindElement(By.Id("droppable"));


    }
}
