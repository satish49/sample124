using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0))
		   {
		
			Debug.LogError("uday");


			Vector3 vectobjposition = this.transform.localPosition;
			Debug.LogError(vectobjposition.x);
			this.transform.localPosition=new Vector3( vectobjposition.x+Input.mousePosition.x,Input.mousePosition.y, vectobjposition.z);
			Debug.LogError(this.transform.localPosition);

		}
	
	}
}
