using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginSceneLoad : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D other)
	{
		//SceneManager.LoadScene("Dark Scene");
		Debug.Log("Scene Found");
	}
}
