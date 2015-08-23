using UnityEngine;
using System.Collections;

public class switchCamera : MonoBehaviour {

	public Camera[] cameras;
	public Camera masterCamera;
	private int index;

	void Start(){
		// push all cameras to back
		foreach(Camera cam in cameras){
			cam.depth = -10;
		}
		masterCamera.depth = 1;
		index = 0;
	}

	void OnGUI(){
		if (GUILayout.Button("Camera Walkthrough")){
			index = (index + 1) % cameras.Length;
		}
	}
		
	void Update(){
		//masterCamera.transform.position =
		//  cameras[index].transform.position;
		//masterCamera.transform.rotation =
		//  cameras[index].transform.rotation;
		
		masterCamera.transform.position = Vector3.Lerp(
			masterCamera.transform.position,
			cameras[index].transform.position,
			0.05f);
		masterCamera.transform.rotation = Quaternion.Lerp(
			masterCamera.transform.rotation,
			cameras[index].transform.rotation,
			0.05f);
	}

}