using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Controllers;
using ToDoList.Models;
using System;


namespace ToDoList.Tests
{
    [TestClass]
    public class ItemControllerTest : IDisposable
    {
        public void Dispose()
        {
            Item.ClearAll();
        }

        [TestMethod]
        public void New_ReturnsCorrectActionType_ViewResult()
        {
            //Arrange
            ItemsController controller = new ItemsController();

            //Act
            IActionResult view = controller.New(1);

            //Assert
            Assert.IsInstanceOfType(view, typeof(ViewResult));
        }

        [TestMethod]
        public void Show_ReturnsCorrectActionType_ViewResult()
        {
          //Arrange
          ItemsController controller = new ItemsController();

          //Act
          IActionResult view = controller.Show(1, 1);

          //Assert
          Assert.IsInstanceOfType(view, typeof(ViewResult));

        }

        [TestMethod]
        public void Show_IsReturningCorrectModel_CategoryObject()
        {
          //Arrange


          //Act

          //Assert

        }


    }
}
