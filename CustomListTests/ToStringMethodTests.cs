using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class ToStringMethodTests
    {
        [TestMethod]
        public void ToString_StringifyList_ReturnResultsForListOfStrings()
        {
            //Take all string values and convert to one string.
            //Arrange
            CustomList<string> thanos = new CustomList<string>();
            thanos.Add("I");
            thanos.Add("Am");
            thanos.Add("Enevitable!");

            //Act
            string listOfStrings = thanos.ToString();

            //Assert
            Assert.AreEqual("IAmEnevitable!",listOfStrings); 
        }

        [TestMethod]
        public void ToString_StringifyList_ReturnResultsForListOfInts()
        {
            //Take all int values and convert to one string.
            //Arrange
            CustomList<int> numbs = new CustomList<int>();
            numbs.Add(1);
            numbs.Add(2);
            numbs.Add(3);

            //Act
            string listOfInts = numbs.ToString();

            //Assert
            Assert.AreEqual("123", listOfInts);
        }

        [TestMethod]
        public void ToString_StringifyEmptyList_ReturnResultsEmptyString()
        {
            //Arrange- Create a new list with nothing in it.
            CustomList<int> numbs = new CustomList<int>();

            //Act
            string listOfInts = numbs.ToString();

            //Assert
            Assert.AreEqual("", listOfInts);
        }
   
    }
}
