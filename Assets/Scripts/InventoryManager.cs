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
}
