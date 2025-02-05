using UnityEngine;
using System.Collections;

public class GUITest : MonoBehaviour
{
	
		// Use this for initialization
		//中文显示
		public GUISkin myGUISkin;
		private Rect windowRect;
		private Vector2 scrollPosition;
		private string info = "";
		public static bool talk = false;

		void Start ()
		{
		
				windowRect = new Rect (300, 10, 350, 510);
				info = "哈哈,你好!\n (终于看到一个人了,你是谁啊?来自哪里啊?)\n 我是 Unity3d 的工程师,\n被遗忘在这个孤岛上多年了!\n一直在寻找能量源物体!\n 如果你找到了请告诉我!";
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

