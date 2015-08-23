using UnityEngine;
using System.Collections;

public class switchMaterials : MonoBehaviour {

	public Material[] materials;
	public Material[] materials_wood;
	public Material[] materials_Floor;

	public Texture2D tex;
	public Texture2D tex1;
	public Texture2D tex2;
	public Texture2D tex3;

	public Texture2D floortexure1;
	public Texture2D floortexure2;
	public Texture2D floortexure3;

	public Texture2D woodtexture1;
	public Texture2D woodtexture2;
	public Texture2D woodtexture3;


     Renderer woodRenderer;
	public Renderer FloorRenderer;
	public Renderer render;
//	public Renderer Render_tapicerk0;
//	public Renderer Render_tapicerk1;
//	public Renderer Render_tapicerk2;
//	public Renderer Render_tapicerk3;
//	public Renderer Render_tapicerk4;
	bool windowstatus =false;
	private int index;
	private bool renderr = false;
	GUI.WindowFunction windowFunction;
	Rect windowRect = new Rect(0, 0, 150, 180);
	GUIStyle guistyyle;
	GUI.WindowFunction windowFunction2;
	Rect windowRect2 = new Rect(170, 0, 250, 120);
	GUI.WindowFunction windowFunction3;
	Rect windowRect3 = new Rect(170, 0, 200, 120);
	GUI.WindowFunction windowFunction4;
	Rect windowRect4 = new Rect(170, 0, 200, 120);
	Rect Windowshortmenu=new Rect(10 ,10, 100, 80);
	GUI.WindowFunction windowFunction5;
	bool woodrenderwindow=false;
	public static bool hidewindows=false;
	bool floorrenderwindow=false;

	// Use this for initialization
	void Start () {
		index = 0;
		windowFunction = DoMyWindow;
		windowFunction2 = DOTypes;
		windowFunction3 = DoWoodFloor;
		windowFunction4 = DOFLoortypes;
		windowFunction5 = OpenMenu;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyUp(KeyCode.M)){
			this.GetComponent<Renderer>().material = materials[index];
			index = (index + 1) % materials.Length;
		}
	}

	
	void DoMyWindow(int windowID)
	{
		RenderSettings.ambientSkyColor = Color.red;
		if (GUI.Button (new Rect (10, 30, 130, 30), "Leather")) {

	
			renderr=true;
			floorrenderwindow=false;
			woodrenderwindow=false;

			
		}

		if (GUI.Button(new Rect(10,60,130,30), "Floor")){
			
			//index = (index + 1) % materials_Floor.Length;
			//FloorRenderer.material=materials_Floor[index];

			renderr = false;
			woodrenderwindow=false;
			floorrenderwindow=true;

		}
		
		if (GUI.Button (new Rect (10, 90, 130, 30), "WoodenFloor")) {
			
			//index = (index + 1) % materials_wood.Length;
			//woodRenderer.material = materials_wood [index];
			renderr =false;
			woodrenderwindow=true;
			floorrenderwindow=false;


		}
		if (GUI.Button (new Rect (10, 120, 130, 30), "Hide-Menu's")) {
			
			//index = (index + 1) % materials_wood.Length;
			//woodRenderer.material = materials_wood [index];
			hidewindows=true;
			renderr =false;
			woodrenderwindow=false;;
			floorrenderwindow=false;
			
			
		}



		GUI.DragWindow ();
	}
	void OnGUI(){
        if (hidewindows == false) {
    
			windowRect = GUI.Window (1, windowRect, windowFunction, "Customize");
		}
			if (renderr == true) {
		
		
		

				windowRect2 = GUI.Window (5, windowRect2, windowFunction2, "Leather-types");

			} 
			if (woodrenderwindow == true) {

				windowRect3 = GUI.Window (6, windowRect3, windowFunction3, "Wooden-Types");
			}
			if (floorrenderwindow == true) {

				windowRect4 = GUI.Window (7, windowRect4, windowFunction4, "Floor-types");
			}
			if(hidewindows==true)
			{
				Windowshortmenu=GUI.Window(9, Windowshortmenu, windowFunction5, "Show-Menu");
				
			}


		System.GC.Collect();
		Resources.UnloadUnusedAssets();

	}
	void DOTypes(int windowID)
	{
		GUI.color = Color.white;
	    GUIContent content = new GUIContent ();
		content.image = (Texture2D)tex;
        
		//content.text= "Pink";
	
		GUIContent content1 = new GUIContent ();
		content1.image = (Texture2D)tex1;
		//content1.text = "Leather";
		GUIContent content2 = new GUIContent ();
		content2.image = (Texture2D)tex2;
		//content2.text = "Blue";
		GUIContent content3 = new GUIContent ();
		content3.image = (Texture2D)tex3;
		//content3.text = "Red";




		if (GUI.Button (new Rect (10, 20, 50, 70),content) ){


			render.material.mainTexture=tex;
//			Render_tapicerk0.material.mainTexture=tex;
//			Render_tapicerk1.material.mainTexture=tex;
//			Render_tapicerk2.material.mainTexture=tex;
//			Render_tapicerk3.material.mainTexture=tex;
//			Render_tapicerk4.material.mainTexture=tex;

		}
		if (GUI.Button (new Rect (60, 20, 50, 70),content1) ){


			render.material.mainTexture=tex1;
//			Render_tapicerk0.material.mainTexture=tex1;
//			Render_tapicerk1.material.mainTexture=tex1;
//			Render_tapicerk2.material.mainTexture=tex1;
//			Render_tapicerk3.material.mainTexture=tex1;
//			Render_tapicerk4.material.mainTexture=tex1;
		}
		if (GUI.Button (new Rect (110, 20, 50, 70),content2) ){


			render.material.mainTexture=tex2;
//			Render_tapicerk0.material.mainTexture=tex2;
//			Render_tapicerk1.material.mainTexture=tex2;
//			Render_tapicerk2.material.mainTexture=tex2;
//			Render_tapicerk3.material.mainTexture=tex2;
//			Render_tapicerk4.material.mainTexture=tex2;
			
		}
		if (GUI.Button (new Rect (160, 20, 50, 70),content3) ){




			render.material.mainTexture=tex3;
//			Render_tapicerk0.material.mainTexture=tex3;
//			Render_tapicerk1.material.mainTexture=tex3;
//			Render_tapicerk2.material.mainTexture=tex3;
//			Render_tapicerk3.material.mainTexture=tex3;
//			Render_tapicerk4.material.mainTexture=tex3;
			
		}
		if(GUI.Button (new Rect (220, 20, 20, 20), "X"))
		   {
			renderr=false;
		
		}

		GUI.DragWindow ();
	}

	void DOFLoortypes(int windowID)
	{

//		
//		GUI.color = Color.white;
//		GUIContent content = new GUIContent ();
//		content.image = (Texture2D)floortexure;
//		
		//content.text= "Pink";
		
		GUIContent content1 = new GUIContent ();
		content1.image = (Texture2D)floortexure1;
		//content1.text = "Leather";
		GUIContent content2 = new GUIContent ();
		content2.image = (Texture2D)floortexure2;
		//content2.text = "Blue";
		GUIContent content3 = new GUIContent ();
		content3.image = (Texture2D)floortexure3;
		//content3.text = "Red";
		
		
		
		
//		if (GUI.Button (new Rect (10, 20, 50, 70),content) ){
//			
//			FloorRenderer.material.mainTexture=floortexure;
//
//			
//		}
		if (GUI.Button (new Rect (10, 20, 50, 70),content1) ){
			
			FloorRenderer.material.mainTexture=floortexure1;
		}
		if (GUI.Button (new Rect (60, 20, 50, 70),content2) ){
			

			FloorRenderer.material.mainTexture=floortexure2;
		}
		if (GUI.Button (new Rect (110, 20, 50, 70),content3) ){
			
			
			
			FloorRenderer.material.mainTexture=floortexure3;
		}
		if(GUI.Button (new Rect (170, 20, 20, 20), "X"))
		{
			floorrenderwindow=false;
			
		}
		
		GUI.DragWindow ();
	}
	void DoWoodFloor(int windowID)
	{

		
//		GUI.color = Color.white;
//		GUIContent content = new GUIContent ();
//		content.image = (Texture2D)woodtexture;
		
		//content.text= "Pink";
		
		GUIContent content1 = new GUIContent ();
		content1.image = (Texture2D)woodtexture1;
		//content1.text = "Leather";
		GUIContent content2 = new GUIContent ();
		content2.image = (Texture2D)woodtexture2;
		//content2.text = "Blue";
		GUIContent content3 = new GUIContent ();
		content3.image = (Texture2D)woodtexture3;
		//content3.text = "Red";
		
		
		
		
//		if (GUI.Button (new Rect (10, 20, 50, 70),content) ){
//			
//			FloorRenderer.material.mainTexture=woodtexture;
//			
//			
//		}
		if (GUI.Button (new Rect (10, 20, 50, 70),content1) ){
			
			FloorRenderer.material.mainTexture=woodtexture1;
		}
		if (GUI.Button (new Rect (60, 20, 50, 70),content2) ){
			
			
			FloorRenderer.material.mainTexture=woodtexture2;
		}
		if (GUI.Button (new Rect (110, 20, 50, 70),content3) ){
			
			
			
			FloorRenderer.material.mainTexture=woodtexture3;
		}
		if(GUI.Button (new Rect (170, 20, 20, 20), "X"))
		{
			woodrenderwindow=false;
			
		}

		GUI.DragWindow ();
	}

	void OpenMenu( int windowID)
	{


		if (GUI.Button (new Rect (10, 30, 70, 25), "ClikMe ...!")) {
		
			hidewindows=false;
		
		}
		GUI.DragWindow ();
	}

}
