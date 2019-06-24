using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class SB : MonoBehaviour
{

		public GUIText Text;
		public struct POINTAPI
		{
				public int x;
				public int y;
		}

		[DllImport("user32.dll")]
		public static extern bool GetCursorPos (ref POINTAPI point);
		// Use this for initialization
		void Start ()
		{
				Text = GameObject.Find ("GUIText").guiText;
		}
	
		void OnGUI ()
		{
				if (GUI.Button (new Rect (10, 330, 200, 100), "恢复鼠标桌面坐标")) {
						POINTAPI p = new POINTAPI ();
						if (GetCursorPos (ref p)) {
								Text.text = "鼠标桌面X：" + p.x + "鼠标桌面Y：" + p.y;
						}
				}
		}
}
