using CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTests
{
    [TestClass]
    public class PlusOverloadMethodTests
    {
        [TestMethod]
        public void PlusOperatorOverload_CombineTwoListsFirstOneLarger_ReturnSingleListWithCombinedData()
        {
            //Arrange- Create 2 seperate lists with same data type.
            CustomList<string> avengersOne = new CustomList<string>();
            CustomList<string> avengersTwo = new CustomList<string>();

            avengersOne.Add("Iron Man");
            avengersOne.Add("Thor");
            avengersOne.Add("Vision");
            avengersOne.Add("Hulk");

            avengersTwo.Add("Spider Man");
            avengersTwo.Add("Ant Man");
            avengersTwo.Add("Black Widow");

            //Act-Add the two lists together.
            CustomList<string> endGame = avengersOne + avengersTwo;

            //Assert- Passed test should show total count of 7 avengers and "Ant Man" at index 5.
            Assert.AreEqual(7, endGame.Count);
            Assert.AreEqual("Ant Man", endGame[5]);
        }

        [TestMethod]
        public void PlusOperatorOverload_CombineTwoListsSecondOneLarger_ReturnSingleListWithCombinedData()
        {
            //Arrange- Create 2 seperate lists with same data type.
            CustomList<string> avengersOne = new CustomList<string>();
            CustomList<string> avengersTwo = new CustomList<string>();

            avengersOne.Add("Iron Man");
            avengersOne.Add("Thor");
            

            avengersTwo.Add("Spider Man");
            avengersTwo.Add("Ant Man");
            avengersTwo.Add("Black Widow");
            avengersTwo.Add("Vision");
            avengersTwo.Add("Hulk");
            //Act
            CustomList<string> endGame = avengersOne + avengersTwo;

            //Assert- Passed test should show total count of 7 avengersand "Ant Man" at index 3.
            Assert.AreEqual(7, endGame.Count);
            Assert.AreEqual("Ant Man", endGame[3]);
        }

        [TestMethod]
        public void PlusOperatorOverload_CombineTwoListsOneEmpty_ReturnSingleListWithCombinedData()
        {
            //Arrange- Create 2 seperate lists with same data type while only adding items to second list.
            CustomList<string> avengersOne = new CustomList<string>();
            CustomList<string> avengersTwo = new CustomList<string>();

            avengersTwo.Add("Iron Man");
            avengersTwo.Add("Thor");
            avengersTwo.Add("Spider Man");
            avengersTwo.Add("Ant Man");
            avengersTwo.Add("Black Widow");
            avengersTwo.Add("Vision");
            avengersTwo.Add("Hulk");

            //Act -Add the 2 lists together
            CustomList<string> endGame = avengersOne + avengersTwo;

            //Assert- Passed test should show total count of 7 avengers and "Ant Man" at index 3.
            Assert.AreEqual(7, endGame.Count);
            Assert.AreEqual("Ant Man", endGame[3]);
        }
    }
}
