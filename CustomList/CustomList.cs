﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomList
{
    public class CustomList<T>
    {
        //Member Variables (HAS A)
        private T[] items;
        private int capacity;
        private int count;

            //Create public properties for capacity and count to get values
        public int Capacity { get =>  capacity; }
        public int Count { get => count; }
            //Create a public indexer for items 
        public T[] Items { get => items; set => items = value; }
            //Need a custom indexer to prevent a user from accessing an out of bounds index. Used for the remove method and overload methods.
        public T this[int index]
        {
            get
            {
                //Conditional checks if there are any indexes available or if the index provided is greater than the actual count.
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException();
                else
                {
                    return items[index];
                }
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    items[index] = value;
                }
            }
        }

        //Constructor
        public CustomList()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity]; //Items array of equal number of places to the capacity
        }

        //Member Methods (CAN DO)
        public void Add(T item)
        {
            //If the capacity reaches max then double capacity. 
            if (capacity == count)
            {
                capacity *= 2;
                //Create new items array with increased capacity
                T[] newItems = new T[capacity];
                //Loop will transfer items from original array to the new array.
                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }
                //Assign the reference of the old array with the new larger array. 
                items = newItems;
            }
            //Now add the new item to the new larger array. 
            //Check to make sure that the count is less than the capacity, then add. If not then throw exception.
            items[count++] = item;

            //'item' parameter should be added to internal 'items' array
            //if items array is at capacity, double capacity and create new array
            //transfer all items to new array
        }
        //Method to shift index value down when removing an item.
        public T[] ShiftIndex(int indexedItem)
        {
            T[] removedItemsArray = new T[capacity];
            //Loop through the array to shift the elements. 
            for (int i = 0; i < count - 1; i++)
            {
                //If the current index is before the indexed item then copy the arrays items in their correct index.
                if (i < indexedItem)
                {
                    //Both arrays are equal.
                    removedItemsArray[i] = items[i];
                }
                else
                {
                    //Else if index is after the indexted item shift the index by skipping the item in the original array.
                    removedItemsArray[i] = items[i + 1];
                }
            }
            return removedItemsArray;
        }

        public bool Remove(T item)
        {
            //Set variable to false and have method check if item exists. If it does then remove the item.
            bool itemExists = false;
            //Need to find the index of an item in a list/array.
            int index = Array.IndexOf(items, item);
            if (index >= 0)
            {
                itemExists = true;
                //Any items coming after the removed item should be shifted down so there is no empty index.
                items = ShiftIndex(index);
                count--;
            }
            //If 'item' exists in the 'items' array, remove its first instance
            
            //If 'item' was removed, return true. If no item was removed, return false.
            return itemExists;
        }


        public override string ToString()
        {
            //returns a single string that contains all items from array
            //Need a value to hold the items from an array into a string. 
            string newString = "";
            int itemCount = 0;
            //Need a loop to go through the list and append it to the newString variable.
            foreach (T item in items)
            {
                //Correct the return for capacity. If Count is lest than item count go into conditionals.This prevents an item being added to a list with less items than its capacity.   
                itemCount++;
                if (itemCount <= count)
                {
                    //Check to see what item datatype is. Ex String or int. Each if statement checks datatype.
                    //<datatype>Item variable can be passed in for composite formating.
                    if (item is string stringItem)
                    {
                        newString += item;
                    }
                    else if (item is int intItem)
                    {
                        newString += String.Format("{0}", intItem);
                    }
                }
            }
            return newString;
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            //Create a new list to hold items from both lists. 
            CustomList<T> combinedList = new CustomList<T>();
            //Loop through each list and add the items to the new list.
            for (int i = 0; i < firstList.Count; i++)
            {
                combinedList.Add(firstList[i]);
            }
            for (int i = 0; i < secondList.Count; i++)
            {
                combinedList.Add(secondList[i]);
            }
            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            return combinedList;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //Create a new list to hold items for to return after minus operation of firstList minus secondList.
            CustomList<T> minusList = new CustomList<T>();
            //Need to compare items from firstList and secondList using for loop.
            for (int i = 0; i < firstList.Count; i++)
            {
                //Variable to hold the value of each iteration.
                T item = firstList[i];
                //If item from the first list is duplicated in the secondList, minus operation should remove a single instance of the duplicated item
                //in the firstList as well as remove all items from the secondList.
                if (!secondList.Contains(item))
                {
                    //If item doesn't exist in secondList, add it to minusList.
                    minusList.Add(item);
                }
                else
                {
                    //If item is duplicated in the secondList, remove the instance from the firstList.
                    firstList.Remove(item);
                }
            }

            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            return minusList;
        }

        //Need to create a method for contains since CustomList<T> does not have a definition for .Contains.
        public bool Contains(T item)
        {
            //Loop through list for items and checks if the item equals an item in items list. If so returns true. 
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }



    }
}
