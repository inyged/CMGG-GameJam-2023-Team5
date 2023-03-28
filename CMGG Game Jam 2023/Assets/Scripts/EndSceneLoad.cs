using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndSceneLoad : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (Inventory.memories == 5)
        {
            SceneManager.LoadScene("End Scene");
            Debug.Log("Scene Found");
        }
    }
}