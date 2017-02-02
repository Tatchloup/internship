using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D (Collider2D other) 
	{

			SceneManager.LoadScene("main");
		
	}
}
