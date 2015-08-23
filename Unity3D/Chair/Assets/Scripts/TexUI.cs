using UnityEngine;
using System.Collections;

public class TexUI : MonoBehaviour {
 // Use this for initialization
    Rect windowRect1 = new Rect(500, 50, 220, 250);
    GUI.WindowFunction windowFunction1;

    void Start()
    {

        windowFunction1 = DoMyWindow1;

    }

    void OnGUI()
    {
        windowRect1 = GUI.Window(0, windowRect1, windowFunction1, "Textures");

    }


    void DoMyWindow1(int windowID1)
    {
    }
}
