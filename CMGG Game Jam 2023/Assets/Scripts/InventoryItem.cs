using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem : MonoBehaviour {

    public ItemData itemData;
    [SerializeField] public int memories = 0;
    
    
    public InventoryItem(ItemData item)
    {
        itemData = item;
    }
    //public int GetMemories { get => memories; }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        memories = 0;
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            memories++;
            Debug.Log("Memory Collected: " + memories);
        }
    }

    // add memories function
    //public void AddItem(GameObject itemToAdd) { items.Add(itemToAdd); }
}