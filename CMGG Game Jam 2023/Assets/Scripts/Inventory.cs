using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<InventoryItem> inventory;
    [SerializeField] public static int memories = 0;

    public void Add(ItemData itemData)
    {
        //Inventory.Add(newItem);
        //Debug.Log($"{item.itemData.displayName} total stack is now {item.stackSize}");
    }

    public static void UpdateMemories()
    {
        memories += 1;
    }

}