
using UnityEngine;
using System.Collections;

public class Introduction : MonoBehaviour
{

	
		// Use this for initialization
		//中文显示
		public GUISkin myGUISkin;
		private Rect windowRect;
		private Vector2 scrollPosition;
		private string info = "";
		public static bool talk = true;
	
		void Start ()
		{
		
				windowRect = new Rect (300, 30, 350, 510);
				info = "你好!\n  欢迎你进入精彩的 Unit3d 世界探索!" +
						"\n 想要在 Unity3D 世界生存下去就得好好学本领!" +
						"\n W-前进、S-后退、A-左移、D-右移、鼠标-调整视角!" +
						"\n先寻找能量源物体吧!" +
						"\n 如果你找到了请告诉工程师!";
		}
	
	
		void  DoMyWindow (int windowID)
		{
		
				GUILayout.BeginVertical ();
				GUILayout.Space (8);
				GUILayout.Button ("", "MyButtonSkin");//自定义样式
				GUILayout.Space (8);
				GUILayout.Label ("", "MyDividerSkin");
				GUILayout.Label ("MyLabelSkin", "MyLabelSkin");
				GUILayout.Label ("", "MyTextSkin");
				GUILayout.BeginHorizontal ();
				scrollPosition = GUILayout.BeginScrollView (scrollPosition, false, true);
				GUILayout.Label (info, "MyTextSkin");
				GUILayout.EndScrollView ();
				GUILayout.EndHorizontal ();
		
				GUILayout.EndVertical ();
		
				if (GUI.Button (new Rect (150, 440, 60, 20), "关闭")) {
						talk = false;
				}
				GUI.DragWindow (new Rect (0, 0, 10000, 10000));
		}
	
		void  OnGUI ()
		{	
				if (talk) {
						GUI.skin = myGUISkin;
						windowRect = GUI.Window (0, windowRect, DoMyWindow, "");
				}
				
		}
}
