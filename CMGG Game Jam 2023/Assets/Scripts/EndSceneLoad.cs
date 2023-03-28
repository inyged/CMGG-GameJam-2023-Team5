using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


//conditional, if 5 memories in inventory and step to certain location, end scene loads
public class EndSceneLoad : MonoBehaviour
{

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("Finding scene...");

		if (Inventory.GetMemories() = 5)
		{
			SceneManager.LoadScene("Memory1");
			Debug.Log("Scene Found");
		}
		else
		{
			Debug.Log("This object does not have the proper scene assigned.");
		}
	}
}