using UnityEngine;
using System.Collections;

public class Fader : MonoBehaviour
{
		public GUITexture LoadGUI;
		// Use this for initialization
		void Start ()
		{
				Rect cur = new Rect (-Screen.width * 0.5f, -Screen.height * 0.5f, Screen.width, Screen.height);
				guiTexture.pixelInset = cur;
		}
	
		// Update is called once per frame
		//"透明变成不透明"
		void Loading ()
		{
				Instantiate (LoadGUI);
		}
}
