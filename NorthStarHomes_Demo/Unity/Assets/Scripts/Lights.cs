using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class Lights : MonoBehaviour
{
    Rect windowRect = new Rect(2, Screen.height - 130, 180, 400);
    GUI.WindowFunction windowFunction;
    public Light[] lights;
	private Light[] scenelights;


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
        foreach (Light l in lights) {

			l.enabled = GUILayout.Toggle (l.enabled, l.name);

           
		}

        
		if(GUILayout.Button("SunLight", new GUILayoutOption[]{ GUILayout.Width (70),GUILayout.Height (30)}))
		   {

			Light tempLight=GameObject.Find("SunLight").GetComponent<Light>();

			if(tempLight.intensity==1f)
			{
				tempLight.intensity=0.3f;
				RenderSettings.ambientIntensity=0.3f;
			}
			else if(tempLight.intensity==0.3f)
			{
				tempLight.intensity=1f;
				RenderSettings.ambientIntensity=1f;
			}


		}

		
		if (GUILayout.Button ("All Lights On/Off", new GUILayoutOption[]{ GUILayout.Width (120),GUILayout.Height (30)})) {
			scenelights = FindObjectsOfType (typeof(Light)) as Light[];
			foreach (Light light in scenelights) {
				if(light.name=="SunLight")
				{
//					if(light.intensity==1f)
//					{
//						light.intensity=0.3f;
//						RenderSettings.ambientIntensity=0.3f;
//					}
//					else if(light.intensity==0.3f)
//					{
//						light.intensity=1f;
//						RenderSettings.ambientIntensity=1f;
//					}
				}

				else if (light.enabled == true) {
					light.enabled=false;
				
				
				} else if(light.enabled==false ){
					light.enabled=true;

				}
			}
		}

        GUI.DragWindow();

    }







}

