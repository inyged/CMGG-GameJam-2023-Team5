using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginSceneLoad : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D other)
	{
		SceneManager.LoadScene("DarkWorld");
		Debug.Log("Scene Found");
	}
}
