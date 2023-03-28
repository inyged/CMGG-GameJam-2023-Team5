using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MemorySceneLoad : MonoBehaviour
{

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("Finding scene...");

		if (Memory.itemid = 1)
		{
			SceneManager.LoadScene("Memory1");
			Debug.Log("Scene Found");
		}
		else if (Memory.itemid = 2)
		{
			SceneManager.LoadScene("Memory2");
			Debug.Log("Scene Found");
		}
		else if(Memory.itemid = 3)
		{
			SceneManager.LoadScene("Memory3");
			Debug.Log("Scene Found");
		}
		else if(Memory.itemid = 4)
		{
			SceneManager.LoadScene("Memory4");
			Debug.Log("Scene Found");
		}
		else if (Memory.itemid = 5)
		{
			SceneManager.LoadScene("Memory5");
			Debug.Log("Scene Found");
		}
		else
        {
			Debug.Log("This object does not have the proper scene assigned.");
        }
	}
}