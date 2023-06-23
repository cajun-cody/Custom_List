using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class SubtractMethodTests
    {
        [TestMethod]
        public void RemoveItem_ItemIsRemoved_ItemCountDecreases()
        {
            //Arrange - Instantiate a new list and add items to it to test removal. 
            CustomList<string> avengers = new CustomList<string>();
            avengers.Add("Iron Man");
            avengers.Add("Captain America");
            avengers.Add("Thor");
            avengers.Add("Vision");
            //Act
            avengers.Remove(avengers[0]);
            //Assert
            Assert.AreEqual(3, avengers.Count);
        }

        [TestMethod]
        public void RemoveItem_ItemIsRemoved_ReturnTrue()
        {
            //Arrange - Instantiate a new list and add items to it to test removal. 
            CustomList<string> avengers = new CustomList<string>();
            avengers.Add("Iron Man");
            avengers.Add("Captain America");
            avengers.Add("Thor");
            avengers.Add("Vision");
            //Act
            bool removed = avengers.Remove("Vision");
            //Assert
            Assert.IsTrue(removed);
        }

        [TestMethod]
        public void RemoveItem_ItemIsRemoved_CountDoesNotDecreaseForNonExistantItems()
        {
            //Arrange - Instantiate a new list and add items to it to test removal. 
            CustomList<string> avengers = new CustomList<string>();
            avengers.Add("Iron Man");
            avengers.Add("Captain America");
            avengers.Add("Thor");
            avengers.Add("Vision");
            //Act
            avengers.Remove("Hawkeye");
            //Assert
            Assert.AreEqual(4, avengers.Count);
        }

        [TestMethod]
        public void RemoveItem_ItemIsRemoved_IndexesShiftBackwardToFillEmptyIndex()
        {
            //Arrange - Instantiate a new list and add items to it to test removal. 
            CustomList<string> avengers = new CustomList<string>();
            avengers.Add("Iron Man");
            avengers.Add("Captain America");
            avengers.Add("Thor");
            avengers.Add("Vision");
            //Act
            avengers.Remove("Captain America");
            //Assert
            Assert.AreEqual("Thor", avengers.Items[1]);
        }

        [TestMethod]
        public void RemoveItem_ItemIsRemoved_OnlyFirstInstanceOFDuplicatedItemsRemoved()
        {
            //Arrange - Instantiate a new list and add items to it to test removal. 
            CustomList<string> avengers = new CustomList<string>();
            avengers.Add("Vision");
            avengers.Add("Iron Man");
            avengers.Add("Captain America");
            avengers.Add("Thor");
            avengers.Add("Iron Man");
            
            //Act
            avengers.Remove("Iron Man");
            //Assert
            Assert.AreEqual("Iron Man", avengers.Items[3]);
        }
    }
}
