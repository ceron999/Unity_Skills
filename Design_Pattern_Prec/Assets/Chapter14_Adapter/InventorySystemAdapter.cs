using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Adapter
{
    public class InventorySystemAdapter : InventorySystem, IInventorySystem
    {
        private List<InventoryItem> _cloudInventory;

        public void SyncInventories()
        {
            var _cloudInventory = GetInventory();
        }

        public void AddItem(InventoryItem item, SaveLocation location)
        {
            if (location == SaveLocation.Cloud)
                AddItem(item);

            if (location == SaveLocation.Local)
                Debug.Log("Add item in local");

            if(location == SaveLocation.Both)
            {
                Debug.Log("Add item to local and cloud");
            }
        }

        public void RemoveItem(InventoryItem item, SaveLocation location)
        {
            Debug.Log("Remove item to local or cloud");
        }

        public List<InventoryItem> GetInventory(SaveLocation location)
        {
            Debug.Log("Get inventory from local and cloud");
            return new List<InventoryItem>();
        }
    }
}