using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem : ScriptableObject {

    [SerializeField] public int memories = 0;
    public ItemData itemData;
    //public int memories;

    public InventoryItem(ItemData item)
    {
        itemData = item;
        AddMemory();
    }
    //public int GetMemories { get => memories; }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Memory"))
        {
            Destroy(collision.gameObject);
            memories++;
            Debug.Log("Memory Collected");
        }
    }
    public void UpdateMemories(int numberOfMemories) { memories += numberOfMemories; }
    // add memories function
    //public void AddItem(GameObject itemToAdd) { items.Add(itemToAdd); }
    public void AddMemory()
    {
        memories += 1;
    }
}