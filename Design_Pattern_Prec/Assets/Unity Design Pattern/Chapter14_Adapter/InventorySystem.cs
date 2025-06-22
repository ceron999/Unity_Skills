using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Adapter
{
    public class InventorySystem
    {
        public void AddItem(InventoryItem item)
        {
            Debug.Log("Add Item");
        }

        public void RemoveItem(InventoryItem item)
        {
            Debug.Log("Remove Item");
        }

        public List<InventoryItem> GetInventory()
        {
            Debug.Log("return Item list");

            return new List<InventoryItem>();
        }
    }
}