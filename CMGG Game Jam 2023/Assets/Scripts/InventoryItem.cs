using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem : MonoBehaviour {

    [SerializeField] public int memories;
    public ItemData itemData;
    //public int memories;

    public InventoryItem(ItemData item)
    {
        itemData = item;
    }
    //public int GetMemories { get => memories; }
    private void OnTriggerEnter2D(Collider2D collision)
    {
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