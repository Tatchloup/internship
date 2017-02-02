using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LangSet : MonoBehaviour 
{

	public string currentlang;
	public string langset;
	private LangStored langStored;
	public GameObject langStoredObj;


	void Start()
	{
		/*langStoredObj = GameObject.FindWithTag("LangStored");
		LangStored langStored = langStoredObj.GetComponent<LangStored>();
		
		Check();	*/	

	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void Check()
	{
		/*if(currentlang!=langset)
		{
			langStored.lang = currentlang;
			langset = currentlang;
		}*/
	}
}
