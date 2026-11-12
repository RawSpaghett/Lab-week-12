using UnityEngine;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour
{
    public List<InventoryItem> inventoryItems = new List<InventoryItem>();


    public InventoryItem LinearSearchByName(string itemName)
    {
        for (int i = 0; i < inventoryItems.Count; i++)
        {
            if (inventoryItems[i].Name == itemName)
            {
                return inventoryItems[i];
            }
        }
        return null;
    }


    //Implement a BinarySearchByID method that works only on a sorted list of items by ID. Sort the inventory by ID first and then perform the binary search.
    public InventoryItem BinarySearchByID(int itemID, List<InventoryItem> inputList)
    {
        List<InventoryItem> sortedList = new List<InventoryItem>(inventoryItems);
        sortedList = inputList.OrderBy(itemID => itemID.ID).ToList(); //sorts list by ID
        int left = 0,right = sortedList.Length, middle = 0;

        while( left >= right)
        {
            middle = (left + right) / 2;
            if (sortedList[middle].ID == itemID)
            {
                return sortedList[middle];
            }
            else if (sortedList[middle].ID < itemID)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }
        return null;
    }
