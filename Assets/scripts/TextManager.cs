using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//Gere le lacement/remplacement du texte
//Mais pas la gestion des != langues

public class TextManager : MonoBehaviour 
{

	public TextAsset textFile;
	public string[] textlines;

	public GameObject textBox;
	public Text thetext;

	public int currentLine;
	public int endLine;

	//public TextAsset newLang;


	// Use this for initialization
	void Start () 
	{
		if(textFile != null)
		{
			//get line from file, new line for each return to the line
			textlines = (textFile.text.Split('\n')); 

		}


		if(endLine == 0)
		{
			//last line is total number of line -1
			//because counter starts at 0
			endLine = textlines.Length - 1;
		}

	}

	public void NextLine()
	{		
			currentLine +=1;

	}

	void Update()
	{
		thetext.text = textlines[currentLine];
	}

	public void Replace()
	{
		//textFile = newLang;
		textlines = (textFile.text.Split('\n')); 
		endLine = textlines.Length - 1;


	}

}
