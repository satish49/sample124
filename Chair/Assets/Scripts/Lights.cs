using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;


public class Lights : MonoBehaviour {
	Rect windowRect = new Rect(2, Screen.height-130, 150, 128);
	GUI.WindowFunction windowFunction;
	 public Light[] lights;

	float mychange1= 1f;	
	float mychange2=2f;	
	float mychange3=4f;	

		// Use this for initialization
	void Start () {
		windowFunction = DoMyWindow;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI()
	{

		if (switchMaterials.hidewindows == false) {
			windowRect = GUI.Window (2, windowRect, windowFunction, "Lights");
		}
		
	}
	
	void DoMyWindow(int windowID)
	{


		float hslider1 = 2.0f;
		float hslider2 = 2.0f;
		float hslider3 = 2.0f;

		foreach (Light l in lights) {
		
			l.enabled = GUILayout.Toggle( l.enabled, l.name );
		

			if(l.name=="LampLight")
			{
				hslider1=GUILayout.HorizontalSlider(mychange1,0,8);
				if(hslider1!= mychange1)
				{

					mychange1=hslider1;
					l.intensity=mychange1;
				}

			}
			if(l.name=="Spotlight01")
			{
				hslider2=GUILayout.HorizontalSlider(mychange2,0,8);
				if(hslider2!= mychange2)
				{
					
					mychange2=hslider2;
					l.intensity=mychange2;
				}
			}
			if(l.name=="Sunlight")
			{
				hslider3=GUILayout.HorizontalSlider(mychange3,0,8);
				if(hslider3!= mychange3)
				{
					
					mychange3=hslider3;
					l.intensity=mychange3;
				}
			}
		}
		GUI.DragWindow ();
	}
}
