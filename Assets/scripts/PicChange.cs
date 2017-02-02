using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PicChange : MonoBehaviour 
{

	// Use this for initialization
	public Sprite nextSprite;
    //Sprite prevSprite;
 
     /// The Array of Images.
     public Sprite[] thisSprite;
     Image[] images;
     public int currentImage;
 
     // Use this for initialization
     void Start() 
     {
         // Get all components of type Image that are children of this GameObject.
         images = gameObject.GetComponentsInChildren<Image>();
     }

     public void NextPic()
     {
        nextSprite = thisSprite[currentImage];
         // Loop through each image and set it's Sprite to the other Sprite.
         foreach (Image image in images)
         {
             //image.sprite = nextSprite;
             image.sprite = nextSprite;
             currentImage +=1;
         }
     }
     
}
