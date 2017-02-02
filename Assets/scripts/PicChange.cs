using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PicChange : MonoBehaviour 
{

	// Use this for initialization
	public Sprite OtherSprite;
 
     /// The Array of Images.
     Image[] images;
 
     // Use this for initialization
     void Start() 
     {
         // Get all components of type Image that are children of this GameObject.
         images = gameObject.GetComponentsInChildren<Image>();
     }

     public void NextPic()
     {
         // Loop through each image and set it's Sprite to the other Sprite.
         foreach (Image image in images)
         {
             image.sprite = OtherSprite;
         }
     }
}
