using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HideFloors : MonoBehaviour
{

    GUI.WindowFunction windowFunction;
    Rect windowRect = new Rect(0, 0, 140, 440);


    //get floors and create objects dynamically
    public GameObject[] floorsList;

    //get viewpoints
    public Camera[] cameras;

    //List<GameObject[]> floors = new List<GameObject[]>();
    //List<Transform[]> floorsObjectss = new List<Transform[]>();

    Dictionary<GameObject, List<Transform>> floorsWithObjects = new Dictionary<GameObject, List<Transform>>();


    // Use this for initialization
    void Start()
    {
        windowFunction = runThis;
        //get no.of floors
      //  print(floorsList.Length);

        //read all values and save to "floorsWithObjects" dictionary
        readAllValues(floorsList);
    }


    private void readAllValues(GameObject[] floorsList)
    {
        //initialize Dictionary
        for (int floor = 0; floor < floorsList.Length; floor++)
        {
            GameObject floorGameObject = floorsList[floor];
            // print(floorsList[floor].name);

            //now find realted objects and save to dictionary
            List<Transform> objectList = findTransformFromGameObject(floorGameObject);
         //   print("floor " + floorGameObject.name + ": " + objectList.Count);

            //now add this to dictionary
            floorsWithObjects.Add(floorGameObject, objectList);
        }
    }

    private List<Transform> findTransformFromGameObject(GameObject floorGameObject)
    {
        //now process gameobject and read thire childerns
        List<Transform> floorTransforms = new List<Transform>();

        //  print(obj.name);
        Transform objTransform = floorGameObject.transform;

        if (objTransform.GetComponent<Renderer>())
        {
            // print("have renderer");
            floorTransforms.Add(objTransform);
        }
        else
        {
            // print("no renderer");
            getAllGround(floorGameObject, floorTransforms);
        }

        return floorTransforms;
    }


    //get render group
    private void getAllGround(GameObject gameObj, List<Transform> whichFloor)
    {
       // Transform objTransform = gameObj.transform;
        //Transform[] all = gameObj.GetComponents<Transform>();
        Transform[] all = gameObj.GetComponentsInChildren<Transform>();
        //print(all.Length);

        foreach (Transform aa in all)
        {
            if (aa.GetComponent<Renderer>())
            {
                //print("have renderer");
                whichFloor.Add(aa);
            }
        }
    }

    // Update is called once per frame
    void OnGUI()
    {
        windowRect = GUI.Window(1, windowRect, windowFunction, "Show/Hide");

        GUI.backgroundColor = Color.green;
    }

    void runThis(int windowId)
    {
        //30, 60, 100, 20
        float left = 10;
        float top = 20;
        float width = 120;
        float height = 20;

        foreach (KeyValuePair<GameObject, List<Transform>> KeyValue in floorsWithObjects)
        {
            GameObject gameObj = KeyValue.Key;
            List<Transform> list = KeyValue.Value;

            //Hide/Show Ground Floor
            if (GUI.Button(new Rect(left, top, width, height), gameObj.name))
            {
                foreach (Transform ss in list)
                {
                    Renderer d = ss.GetComponent<Renderer>();
                    d.enabled = !d.enabled;
                }
                //Renderer d = gameObj.GetComponent<Renderer>();
                //d.enabled = !d.enabled;

                //GUI.backgroundColor = Color.blue;
                //float xx = gameObj.transform.localPosition.x;
                //float yy = gameObj.transform.localPosition.y;
                //float zz = gameObj.transform.localPosition.z;
                //print("tran prev=" + "  " + xx + "  " + yy + "  " + zz);
                
                //Vector3 temp = new Vector3(xx, yy, -69.4f);
                //gameObj.transform.position = temp;

                //print("tran upda=" + "  " + temp.x + "  " + temp.y + "  " + temp.z);
                

                //float xr = gameObj.transform.eulerAngles.x;
                //float yr = gameObj.transform.eulerAngles.y;
                //float zr = gameObj.transform.eulerAngles.z;
              
                //print("rot prev=" + "  " + xr + "  " + yr + "  " + zr);

                //Vector3 sam = new Vector3(xr, -111f, zr);
                //gameObj.transform.eulerAngles = sam;
                //print("rot next=" + "  " + sam.x + "  " + sam.y + "  " + sam.z );

                //foreach (Transform ss in list)
                //{
                //    Renderer d = ss.GetComponent<Renderer>();
                //    d.enabled = true;
                //}

                ////disable remainting 
                //if (false) { }
                //else
                //{
                //    foreach (Transform ss in list)
                //    {
                //        Renderer d = ss.GetComponent<Renderer>();
                //        d.enabled = false;
                //    }
                //}
            }


            top = top + 20;
        }

        GUI.DragWindow();
    }
}


//Floor planes
/*
*1) 3,7,11
*2) 4,8,12
*3) 5,9,13
*4) 6,10,14
*5) 15
* 
* 
*/