using CustomList;


namespace CustomListTests
{
    [TestClass]
    public class AddMethodsTests
    {
        [TestMethod]
        public void Add_AddNewItem_ItemCountIncreases()
        {
            //Arrange
            CustomList<string> avengers = new CustomList<string>();

            //Act
            avengers.Add("Iron Man");
            //Assert
            Assert.AreEqual(1, avengers.Count);
        }

        [TestMethod]
        public void Add_AddNewItem_FirstItemAtIndexZero()
        {
            //Arrange
            CustomList<string> avengers = new CustomList<string>();

            //Act
            avengers.Add("Iron Man");
            avengers.Add("Captian America");
            //Assert
            Assert.AreEqual("Iron Man", avengers.Items[0]);
        }

        [TestMethod]
        public void Add_Add2Items_SecondItemAtIndexOne()
        {
            //Arrange
            CustomList<string> avengers = new CustomList<string>();

            //Act
            avengers.Add("Iron Man");
            avengers.Add("Captain America");
            //Assert
            Assert.AreEqual("Captain America", avengers.Items[1]);
        }

        [TestMethod]
        public void Add_AddMoreThanFourItems_CapacityIncreaseToFive()
        {
            //Arrange
            CustomList<string> avengers = new CustomList<string>();

            //Act
            avengers.Add("Iron Man");
            avengers.Add("Captain America");
            avengers.Add("Thor");
            avengers.Add("Vision");
            avengers.Add("Hulk");
            //Assert
            Assert.AreEqual(8, avengers.Capacity);
        }

        [TestMethod]
        public void Add_ItemAtSameIndexAfterCapacityIncrease_SecondItemAtIndexOne()
        {
            //Arrange
            CustomList<string> avengers = new CustomList<string>();

            //Act
            avengers.Add("Iron Man");
            avengers.Add("Captain America");
            //Assert
            Assert.AreEqual("Captain America", avengers.Items[1]);

        }
    }
}