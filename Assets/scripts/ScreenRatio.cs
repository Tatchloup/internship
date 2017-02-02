﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenRatio : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
	{
	    // set the desired aspect ratio (the values in this example are
	    // hard-coded for 16:9, but you could make them into public
	    // variables instead, so you can set them at design time)
	    float targetAspect = 1.0f / 1.5f;

	    // determine the game window's current aspect ratio
	    float windowAspect = (float)Screen.width / (float)Screen.height;

	    // current viewport height should be scaled by this amount
	    float scaleHeight = windowAspect / targetAspect;

	    // obtain camera component so we can modify its viewport
	    Camera camera = GetComponent<Camera>();

	    // if scaled height is less than current height, add letterbox
	    if (scaleHeight < 1.0f)
	    {  
	        Rect rect = camera.rect;

	        rect.width = 1.0f;
	        rect.height = scaleHeight;
	        rect.x = 0;
	        rect.y = (1.0f - scaleHeight) / 2.0f;
	        
	        camera.rect = rect;
	    }
	    else // add pillarbox
	    {
	        float scaleWidth = 1.0f / scaleHeight;

	        Rect rect = camera.rect;

	        rect.width = scaleWidth;
	        rect.height = 1.0f;
	        rect.x = (1.0f - scaleWidth) / 2.0f;
	        rect.y = 0;

	        camera.rect = rect;
	    }
	}
}
