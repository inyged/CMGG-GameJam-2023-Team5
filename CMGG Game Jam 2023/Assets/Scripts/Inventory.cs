using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventory : MonoBehaviour 
{
    public List<InventoryItem> inventory;

    //private void OnEnable()
    //{
    //    Memory.OnMemoryCollected += Add();
    //}

    public void Add(ItemData itemData)
    {
        Inventory.Add(newItem);
        //Debug.Log($"{item.itemData.displayName} total stack is now {item.stackSize}");
    }
}