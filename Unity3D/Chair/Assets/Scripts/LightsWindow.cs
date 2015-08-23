using UnityEngine;
using System.Collections;

public class LightsWindow : MonoBehaviour {

    public Light light1;
    public Light light2;
    public Light light3;

   
    GUI.WindowFunction windowFunction1;
    Rect windowRect1 = new Rect(0, 200, 180, 150);

    void Start()
    {
        windowFunction1 = DoMyWindow1;
    }

    void OnGUI()
    {
        windowRect1 = GUI.Window(2, windowRect1, windowFunction1, "Lights");
    }


    void DoMyWindow1(int windowID)
    {
        //Creates button


        var toggleBoolNew1 = GUI.Toggle(new Rect(10, 20, 100, 20), false, "Lamp Light");

        var toggleBoolNew2 = GUI.Toggle(new Rect(10, 40, 100, 20), false, "Spot Light");

        var toggleBoolNew3 = GUI.Toggle(new Rect(10, 60, 100, 20), false, "Sun Light");

        if (toggleBoolNew1)
        {            
            light1.enabled = true;
            light2.enabled = false;
            light3.enabled = false;

            GUI.Toggle(new Rect(10, 20, 100, 20), true, "Lamp Light");
        }
        else
        {
            light1.enabled = false;
            light2.enabled = false;
            light3.enabled = false;

            GUI.Toggle(new Rect(10, 20, 100, 20), false, "Lamp Light");
        }



        if (toggleBoolNew2)
        {
            light1.enabled = false;
            light2.enabled = true;
            light3.enabled = false;
            GUI.Toggle(new Rect(10, 40, 100, 20), true, "Spot Light");
        }
        else
        {
            light1.enabled = false;
            light2.enabled = true;
            light3.enabled = false;
            GUI.Toggle(new Rect(10, 40, 100, 20), false, "Spot Light");
        }


        if (toggleBoolNew3)
        {
            light1.enabled = false;
            light2.enabled = false;
            light3.enabled = true;
            GUI.Toggle(new Rect(10, 60, 100, 20), true, "Sun Light");
        }
        else
        {
            light1.enabled = false;
            light2.enabled = false;
            light3.enabled = false;
            GUI.Toggle(new Rect(10, 60, 100, 20), false, "Sun Light");
        }

        GUI.DragWindow();
    }

    void Update()
    {
     
    }
}
