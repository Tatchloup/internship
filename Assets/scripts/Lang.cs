using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lang : MonoBehaviour 
{
	public GameObject thisLang; //(to be picked in interface)
	public GameObject mc;
	public string thislang;
	private string currentlang;
	private string setlang;
	public TextAsset textFile;
	public string[] textlines;
	public TextAsset newLang;
	private TextManager textManager;


	// Use this for initialization
	void Start () 
	{
		mc = GameObject.Find("MainCamera");
		/*textManager = (TextManager)mc.GetComponent(typeof(TextManager));
		textFile = textManager.Component.TextAsset("textFile");*/
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
/*
	Switch()
		set var thislang to currentlang;
		set/replace all texts using xml file; //Replace() (?)
		set var currentlang to setlang;
		*/
	void Switch()
	{
		currentlang=thislang;
//replace texts
		

		setlang=currentlang;

	}
	/*Replace() - Set text intot the text lines*/
	public void Replace()
	{
		textFile = newLang;
		textlines = (textFile.text.Split('\n')); 
		//endLine = textlines.Length - 1;


	}


}
