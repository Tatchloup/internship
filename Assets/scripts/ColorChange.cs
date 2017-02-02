using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour 
{
	public Color color1 = Color.red;
    public Color color2 = Color.blue;
    public Color color3 = Color.yellow;
    public Color color4 = Color.green;

    public float duration = 3.0F;
    
    Camera camera;
    
    void Start() 
    {
    	camera = GetComponent<Camera>();
    	camera.clearFlags = CameraClearFlags.SolidColor;
    }

	public void Switch() 
	{
		float t = Mathf.PingPong(Time.time, duration) / duration;
	    camera.backgroundColor = Color.Lerp(color1, color2, t);
	}
	public void Switchv2() 
	{
		float t = Mathf.PingPong(Time.time, duration) / duration;
	    camera.backgroundColor = Color.Lerp(color3, color4, t);
	}
}
