using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class Lights : MonoBehaviour
{
    Rect windowRect = new Rect(2, Screen.height - 130, 180, 390);
    GUI.WindowFunction windowFunction;
    public Light[] lights;


    // Use this for initialization
    void Start()
    {
        windowFunction = DoMyWindow;


    }

    // Update is called once per frame
    void Update()
    {


    }
    void OnGUI()
    {
        windowRect = GUI.Window(4, windowRect, windowFunction, "Lights");

    }

    void DoMyWindow(int windowID)
    {
        foreach (Light l in lights)
        {

            l.enabled = GUILayout.Toggle(l.enabled, l.name);
			if(l.name=="SunLight" && l.enabled==false)
			{
				l.intensity=0.3f;
				RenderSettings.ambientIntensity=0.3f;
			}
			else if(l.name=="SunLight" && l.enabled==true)
			{
				l.intensity=1f;
				RenderSettings.ambientIntensity=1f;

			}

        }
        GUI.DragWindow();

    }







}

