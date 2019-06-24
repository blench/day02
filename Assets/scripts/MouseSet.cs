using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class MouseSet : MonoBehaviour
{
		[DllImport("user32.dll")]
		public static extern int SetCursorPos (int x, int y);
		
		public bool Check = false;
		void Start ()
		{
				SetCursorPos (200, 200);
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (!Check) {
						//设置鼠标坐标
						if (Input.mousePosition.x < 1) {
								SetCursorPos (Mathf.RoundToInt (Screen.width * 0.5f), Mathf.RoundToInt (Input.mousePosition.y));
						}
						if (Input.mousePosition.y < 1) {
								SetCursorPos (Mathf.RoundToInt (Input.mousePosition.x), Mathf.RoundToInt (Screen.height * 0.5f));
						}
						//设置鼠标不超过鼠标宽度 - 5 
						if (Input.mousePosition.x > Screen.width - 5) {
								SetCursorPos (Mathf.RoundToInt (Screen.width * 0.5f), Mathf.RoundToInt (Input.mousePosition.y));
						}
				}
		}

		//失去焦点事件
		void OnApplicationFocus ()
		{
				Check = !Check;
		}
}
