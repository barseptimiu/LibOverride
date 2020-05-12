using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibModels.Tests
{
    [TestClass]
    public class LibFactoryTests
    {
        DropDownMock dropDownMock = new DropDownMock();

        [TestMethod]
        public void AndroidAutoApp_Object()
        {
            // Arrange
            LibFactory libFactory = new LibFactory();
            ReplaceableLib lib;
            AndroidAutoApp androidAutoApp = new AndroidAutoApp();

            // Act
            lib = libFactory.Create(dropDownMock.SelectedItem(0));

            // Assert
            Assert.AreEqual(androidAutoApp.GetType(), lib.GetType());
        }

        [TestMethod]
        public void AndroidAutoAppLogic_Object()
        {
            // Arrange
            LibFactory libFactory = new LibFactory();
            ReplaceableLib lib;
            AndroidAutoAppLogic androidAutoAppLogic = new AndroidAutoAppLogic();

            // Act
            lib = libFactory.Create(dropDownMock.SelectedItem(1));

            // Assert
            Assert.AreEqual(androidAutoAppLogic.GetType(), lib.GetType());
        }

        [TestMethod]
        public void AndroidAutoAppFramework_Object()
        {
            // Arrange
            LibFactory libFactory = new LibFactory();
            ReplaceableLib lib;
            AndroidAutoAppFramework androidAutoAppFramework = new AndroidAutoAppFramework();

            // Act
            lib = libFactory.Create(dropDownMock.SelectedItem(2));

            // Assert
            Assert.AreEqual(androidAutoAppFramework.GetType(), lib.GetType());
        }

        [TestMethod]
        public void AndroidAutoHMI_Object()
        {
            // Arrange
            LibFactory libFactory = new LibFactory();
            ReplaceableLib lib;
            AndroidAutoHMI androidAutoHMI = new AndroidAutoHMI();

            // Act
            lib = libFactory.Create(dropDownMock.SelectedItem(3));

            // Assert
            Assert.AreEqual(androidAutoHMI.GetType(), lib.GetType());
        }

        [TestMethod]
        public void Null_Object()
        {
            // Arrange
            LibFactory libFactory = new LibFactory();
            ReplaceableLib lib;

            // Act
            lib = libFactory.Create(dropDownMock.SelectedItem(5));

            // Assert
            Assert.IsNull(lib);
        }
    }
}
