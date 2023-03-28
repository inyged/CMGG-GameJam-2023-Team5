using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField] Inventory inventory = null;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Memory"))
        {
            Inventory.UpdateMemories(1);
            Destroy(collision.gameobject);
            // call MemorySceneLoad
            MemorySceneLoad.OnTriggerEnter2D(collision);
        }
    }
}