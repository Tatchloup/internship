using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lang : MonoBehaviour 
{
	public int thisLang;
	public GameObject staticIntel;

	void Awake()
	{
		staticIntel = GameObject.FindWithTag("LangData");

	}

	public void SwitchLang()
	{
		staticIntel.GetComponent<LangSet>().langPicked = thisLang;
	}


	// Use this for initialization
	/*void Start () 
	{
		mc = GameObject.Find("MainCamera");
		textManager = (TextManager)mc.GetComponent(typeof(TextManager));
		textFile = textManager.Component.TextAsset("textFile");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	Switch()
		set var thislang to currentlang;
		set/replace all texts using xml file; //Replace() (?)
		set var currentlang to setlang;
		
	void Switch()
	{
		currentlang=thislang;
//replace texts
		

		setlang=currentlang;

	}
	Replace() - Set text intot the text lines
	public void Replace()
	{
		textFile = newLang;
		textlines = (textFile.text.Split('\n')); 
		//endLine = textlines.Length - 1;


	}*/


}
