using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Adapter
{
    public interface IInventorySystem 
    {
        void SyncInventories();

        void AddItem(InventoryItem item, SaveLocation location);

        public void RemoveItem(InventoryItem item, SaveLocation location);

        public List<InventoryItem> GetInventory(SaveLocation location);
    }
}