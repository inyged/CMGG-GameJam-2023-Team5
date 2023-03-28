using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : ScriptableObject {

    [SerializeField] int memories = 0;
    public int GetMemories { get => memories; }
    public void UpdateMemories(int numberOfMemories) { memories => numberOfMemories; }
    // add memories function
    //public void AddItem(GameObject itemToAdd) { items.Add(itemToAdd); }

}