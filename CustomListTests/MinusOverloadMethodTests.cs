using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class MinusOverloadMethodTests
    {
        [TestMethod]
        public void MinusOperatorOverload_CombineTwoListsFirstListLarger_ResultsInCombinedListDataOnlyFromListOne()
        {
            //Arrange- Create 2 seperate lists with same data type.
            CustomList<string> avengersOne = new CustomList<string>();
            CustomList<string> avengersTwo = new CustomList<string>();

            avengersOne.Add("Iron Man");
            avengersOne.Add("Thor");
            avengersOne.Add("Ant Man");
            avengersOne.Add("Vision");
            avengersOne.Add("Hulk");

            avengersTwo.Add("Spider Man");
            avengersTwo.Add("Black Widow");

            //Act-Subtract all contents from list 2.
            CustomList<string> endGame = avengersOne - avengersTwo;

            //Assert- Passed test should show total count of 5 avengers and "Ant Man" at index 2.
            Assert.AreEqual(5, endGame.Count);
            Assert.AreEqual("Vision", endGame[3]);
        }

        [TestMethod]
        public void MinusOperatorOverload_CombineTwoListsSecondListLarger_ResultsInCombinedListDataOnlyFromListOne()
        {
            //Arrange- Create 2 seperate lists with same data type.
            CustomList<string> avengersOne = new CustomList<string>();
            CustomList<string> avengersTwo = new CustomList<string>();

            avengersOne.Add("Iron Man");
            avengersOne.Add("Thor");
            avengersOne.Add("Hulk");

            avengersTwo.Add("Spider Man");
            avengersTwo.Add("Ant Man");
            avengersTwo.Add("Black Widow");
            avengersTwo.Add("Vision");
            avengersTwo.Add("Hulk");
            //Act
            CustomList<string> endGame = avengersOne - avengersTwo;

            //Assert- Passed test should show total count of 3 avengersand "Hulk" at index 2.
            Assert.AreEqual(2, endGame.Count);
            Assert.AreEqual("Thor", endGame[1]);
        }

        [TestMethod]
        public void PlusOperatorOverload_CombineTwoListsOneEmpty_ReturnSingleListWithCombinedData()
        {
            //Arrange- Create 2 seperate lists with same data type while only adding items to second list.
            CustomList<string> avengersOne = new CustomList<string>();
            CustomList<string> avengersTwo = new CustomList<string>();

            avengersOne.Add("Iron Man");
            avengersOne.Add("Thor");
            avengersOne.Add("Spider Man");
            avengersOne.Add("Ant Man");


            //Act -Add the 2 lists together
            CustomList<string> endGame = avengersOne - avengersTwo;

            //Assert- Passed test should show total count of 4 avengers and "Ant Man" at index 3.
            Assert.AreEqual(4, endGame.Count);
            Assert.AreEqual("Ant Man", endGame[3]);
        }

        [TestMethod]
        public void MinusOperatorOverload_CombineTwoListsRemoveDuplicatesInstance_ResultsInCombinedListConfirmAllDataWithRemovedItem()
        {
            //Arrange- Create 2 seperate lists with same data type.
            CustomList<string> avengersOne = new CustomList<string>();
            CustomList<string> avengersTwo = new CustomList<string>();

            avengersOne.Add("Iron Man");
            avengersOne.Add("Thor");
            avengersOne.Add("Hulk");

            avengersTwo.Add("Spider Man");
            avengersTwo.Add("Ant Man");
            avengersTwo.Add("Black Widow");
            avengersTwo.Add("Vision");
            avengersTwo.Add("Hulk");
            //Act
            CustomList<string> endGame = avengersOne - avengersTwo;

            //Assert- Passed test should show total count of 3 avengers and "Hulk" at index 2.
            Assert.AreEqual(2, endGame.Count);
            Assert.AreEqual("Thor", endGame[1]);
        }
    }
}
