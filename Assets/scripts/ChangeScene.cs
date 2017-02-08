using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour 
{

	public string thisScene;
	// Use this for initialization
	public void Change()
	{

			SceneManager.LoadScene(thisScene);
		
	}
}