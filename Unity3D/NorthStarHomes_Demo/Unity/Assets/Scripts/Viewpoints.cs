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
	public Camera camera7;
	public Camera camera8;
	public Camera camera9;
	public static string currentCameraName="";
   
    // Use this for initialization
   
    GUI.WindowFunction windowFunction;
	Rect windowRect = new Rect(600, 0, 150, 210);
    
    void Start()
    { 
        windowFunction = DoMyWindow;
    }

    void OnGUI()
    {
        windowRect = GUI.Window(0, windowRect, windowFunction, "Viewpoints");
    }


    void DoMyWindow(int windowID)
    {
        //Creates button

        if (GUI.Button(new Rect(10, 20, 130, 20), camera1.name))
        {
            currentCameraName = camera1.name;
            selectedViewpoint = "Viewpoint1";
            Update();
        }

        if (GUI.Button(new Rect(10, 40, 130, 20), camera2.name))
        {
            currentCameraName = camera2.name;
            selectedViewpoint = "Viewpoint2";
            Update();
        }
        if (GUI.Button(new Rect(10, 60, 130, 20), camera3.name))
        {
            currentCameraName = camera3.name;
            selectedViewpoint = "Viewpoint3";
            Update();

        }
		if (GUI.Button(new Rect(10, 80, 130, 20), camera4.name))
		{
            currentCameraName = camera4.name;
			selectedViewpoint = "Viewpoint4";
			Update();
			
		}

        if (GUI.Button(new Rect(10, 100, 130, 20), camera5.name))
		{
            currentCameraName = camera5.name;
			selectedViewpoint = "Viewpoint5";
			Update();
			
		}

		if (GUI.Button(new Rect(10, 120, 130, 20), camera6.name))
		{
			currentCameraName = camera6.name;
			selectedViewpoint = "Viewpoint6";
			Update();
			
		}

		if (GUI.Button(new Rect(10, 140, 130, 20), camera7.name))
		{
			currentCameraName = camera7.name;
			selectedViewpoint = "Viewpoint7";
			Update();
			
		}

		if (GUI.Button(new Rect(10, 160, 130, 20), camera8.name))
		{
			currentCameraName = camera8.name;
			selectedViewpoint = "Viewpoint8";
			Update();
			
		}

		if (GUI.Button(new Rect(10, 180, 130, 20), camera9.name))
		{
			currentCameraName = camera9.name;
			selectedViewpoint = "Viewpoint9";
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
			camera7.enabled=false;
			camera8.enabled=false;
			camera9.enabled=false;
			
            currentCameraName = camera1.name;
        }
        else if (selectedViewpoint == "Viewpoint2")
        {
            camera1.enabled = false;
            camera2.enabled = true;
            camera3.enabled = false;
			camera4.enabled=false;
			camera5.enabled=false;
			camera6.enabled=false;
			camera7.enabled=false;
			camera8.enabled=false;
			camera9.enabled=false;
            currentCameraName = camera2.name;

        }
        else if (selectedViewpoint == "Viewpoint3")
        {
            camera1.enabled = false;
            camera2.enabled = false;
            camera3.enabled = true;
			camera4.enabled=false;
			camera5.enabled=false;
			camera6.enabled=false;
			camera7.enabled=false;
			camera8.enabled=false;
			camera9.enabled=false;
            currentCameraName = camera3.name;
        }
		else if (selectedViewpoint == "Viewpoint4")
		{			
			camera1.enabled = false;
			camera2.enabled = false;
			camera3.enabled = false;
			camera4.enabled=true;
			camera5.enabled=false;
			camera6.enabled=false;
			camera7.enabled=false;
			camera8.enabled=false;
			camera9.enabled=false;
            currentCameraName = camera4.name;
		}
		else if (selectedViewpoint == "Viewpoint5")
		{			
			camera1.enabled = false;
			camera2.enabled = false;
			camera3.enabled = false;
			camera4.enabled=false;
			camera5.enabled=true;
			camera6.enabled=false;
			camera7.enabled=false;
			camera8.enabled=false;
			camera9.enabled=false;
            currentCameraName = camera5.name;
		}
		else if (selectedViewpoint == "Viewpoint6")
		{			
			camera1.enabled = false;
			camera2.enabled = false;
			camera3.enabled = false;
			camera4.enabled=false;
			camera5.enabled=false;
			camera6.enabled=true;
			camera7.enabled=false;
			camera8.enabled=false;
			camera9.enabled=false;		
            currentCameraName = camera6.name;
		}
		else if (selectedViewpoint == "Viewpoint7")
		{			
			camera1.enabled = false;
			camera2.enabled = false;
			camera3.enabled = false;
			camera4.enabled=false;
			camera5.enabled=false;
			camera6.enabled=false;
			camera7.enabled=true;
			camera8.enabled=false;
			camera9.enabled=false;		
			currentCameraName = camera7.name;
		}
		else if (selectedViewpoint == "Viewpoint8")
		{			
			camera1.enabled = false;
			camera2.enabled = false;
			camera3.enabled = false;
			camera4.enabled=false;
			camera5.enabled=false;
			camera6.enabled=false;
			camera7.enabled=false;
			camera8.enabled=true;
			camera9.enabled=false;		
			currentCameraName = camera8.name;
		}
		else if (selectedViewpoint == "Viewpoint9")
		{			
			camera1.enabled = false;
			camera2.enabled = false;
			camera3.enabled = false;
			camera4.enabled=false;
			camera5.enabled=false;
			camera6.enabled=false;
			camera7.enabled=false;
			camera8.enabled=false;
			camera9.enabled=true;		
			currentCameraName = camera9.name;
		}
        else
        {
        }
    }
}
