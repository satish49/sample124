var lights : Light[];

function OnGUI()
{
	//GUILayout.BeginArea( Rect( 2, Screen.height-130, 150, 128 ), "Lights", GUI.skin.window); 
	
	GUILayout.BeginArea( Rect( 2, Screen.height-130, 150, 128),"Lights", GUI.skin.window);
	for( var l in lights )
	{
	  //  print(l.name);
		l.enabled = GUILayout.Toggle( l.enabled, l.name );
	}
  
   
  
	GUILayout.EndArea();
	///GUI.DragWindow(Rect(0 , 0,1000,1000));
   
}

function Update()
{
   // GUI.DragWindow();
   // print("hello");
}
