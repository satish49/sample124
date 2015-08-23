using UnityEngine;
using System.Collections;

public class switchMaterials1 : MonoBehaviour {

	public Material[] materials;
	private int index;

	public Renderer render;

	// Use this for initialization
	void Start () {
		index = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
       // print("meterial");
		if (Input.GetKeyUp(KeyCode.M)){
			this.GetComponent<Renderer>().material = materials[index];
			index = (index + 1) % materials.Length;
		}
	}

	void OnGUI(){

      //  print("-------------"+Event.current+"----------");
        
        

		if (GUI.Button(new Rect(10,60,130,30), "Floor Types")){

			index = (index + 1) % materials.Length;

			render.material=materials[index];
            System.GC.Collect();
            Resources.UnloadUnusedAssets();
            
//			this.GetComponent<Renderer>().material = materials[index];
//		
//			index = (index + 1) % materials.Length;
		}
		if (GUI.Button(new Rect(10,90,130,30), "WoodenFloor_Types")){
			
			index = (index + 1) % materials.Length;
			
			render.material=materials[index];
			
			
		}


	}



}
