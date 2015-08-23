using UnityEngine;
using System.Collections;

public class Viewpoints : MonoBehaviour {
  public string selectedViewpoint;

    public Camera camera1;
    public Camera camera2;
    public Camera camera3;
	public Camera camera4;
	public Camera camera5;
	public Camera camera6;

    // Use this for initialization
   
    GUI.WindowFunction windowFunction;
	Rect windowRect = new Rect(600, 0, 120, 150);
    
    void Start()
    { 
        windowFunction = DoMyWindow;

    }

    void OnGUI()
    {
		if (switchMaterials.hidewindows == false) {
			windowRect = GUI.Window (0, windowRect, windowFunction, "Viewpoints");
			camera6.enabled = true;
		}

    }


    void DoMyWindow(int windowID)
    {
        //Creates button

        if (GUI.Button(new Rect(10, 20, 100, 20), "Top-1"))
        {
            selectedViewpoint = "Viewpoint1";
            Update();
        }

		if (GUI.Button(new Rect(10, 40, 100, 20), "Front-1"))
        {
            selectedViewpoint = "Viewpoint2";
            Update();
        }
        if (GUI.Button(new Rect(10, 60, 100, 20), "Left-1"))
        {
            selectedViewpoint = "Viewpoint3";
            Update();

        }
		if (GUI.Button(new Rect(10, 80, 100, 20), "Back-1"))
		{
			selectedViewpoint = "Viewpoint4";
			Update();
			
		}

		if (GUI.Button(new Rect(10, 100, 100, 20), "Top-2"))
		{
			selectedViewpoint = "Viewpoint5";
			Update();
			
		}
		if (GUI.Button(new Rect(10, 120, 100, 20), "Front-2"))
		{
			selectedViewpoint = "Viewpoint6";
			Update();
			
		}
      
        GUI.DragWindow();
    }
    void Update()
    {

        if (selectedViewpoint == "Viewpoint1")
        {
            camera1.enabled = true;
            camera2.enabled = false;
            camera3.enabled = false;
			camera4.enabled=false;
			camera5.enabled=false;
			camera6.enabled=false;
        }
        else if (selectedViewpoint == "Viewpoint2")
        {
            camera1.enabled = false;
            camera2.enabled = true;
            camera3.enabled = false;
			camera4.enabled=false;
			camera5.enabled=false;
			camera6.enabled=false;

        }
        else if (selectedViewpoint == "Viewpoint3")
        {
            camera1.enabled = false;
            camera2.enabled = false;
            camera3.enabled = true;
			camera4.enabled=false;
			camera5.enabled=false;
			camera6.enabled=false;           
        }
		else if (selectedViewpoint == "Viewpoint4")
		{			
			camera1.enabled = false;
			camera2.enabled = false;
			camera3.enabled = false;
			camera4.enabled=true;
			camera5.enabled=false;
			camera6.enabled=false;
		}
		else if (selectedViewpoint == "Viewpoint5")
		{			
			camera1.enabled = false;
			camera2.enabled = false;
			camera3.enabled = false;
			camera4.enabled=false;
			camera5.enabled=true;
			camera6.enabled=false;
		}
		else if (selectedViewpoint == "Viewpoint6")
		{			
			camera1.enabled = false;
			camera2.enabled = false;
			camera3.enabled = false;
			camera4.enabled=false;
			camera5.enabled=false;
			camera6.enabled=true;			
		}
        else
        {
        }
    }
}
