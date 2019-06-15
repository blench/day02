using UnityEngine;
using System.Collections;

public class DoorManager : MonoBehaviour
{

		private bool doorIsOpen = false;
		public float doorTimer = 0.0f;
	
		public float doorOpenTime = 3.0f;
		public AudioClip doorOpenSound;
		public AudioClip doorShutSound;
	
		public GUIText hintText;
		public float hintTime = 0.0f;
		// Update is called once per frame
		public static bool WindowSwitch = false;
		private Rect WindowRect = new Rect (40, 100, 240, 200);
	
		void Update ()
		{
				if (doorIsOpen) {
						doorTimer += Time.deltaTime;
						if (doorTimer > doorOpenTime) {
								door (false, doorShutSound, "closeDoor");
								doorTimer = 0.0f;
						}
				}
				//计时关闭文字显示
				if (hintText.enabled) {
						hintTime += Time.deltaTime;
						if (hintTime > 8.0f) {
								hintText.enabled = false;
								hintTime = 0.0f;
						}
				}

				//退出游戏
				if (Input.GetKeyDown (KeyCode.Escape)) {
						WindowSwitch = !WindowSwitch;
				}
		
		}
	
		void OnControllerColliderHit (ControllerColliderHit hit)
		{
				if (hit.gameObject.tag == "playerDoor" && doorIsOpen == false) {
						//openDoor (hit.gameObject);
						door (true, doorOpenSound, "openDoor");
				}
		}
	
		void door (bool doorCheck, AudioClip aClip, string animName)
		{
				doorIsOpen = doorCheck;
				audio.PlayOneShot (aClip);
				transform.parent.animation.Play (animName);
		
		}
	
		void DoorCheck ()
		{
				if (!doorIsOpen && Inventory.charge == 4) {
						door (true, doorOpenSound, "openDoor");
				}
		}

		//绘制GUI窗口退出函数
		void OnGUI ()
		{
				if (WindowSwitch) {
						WindowRect = GUI.Window (0, WindowRect, WindowContain, "测试窗口");
				}
		}

		void WindowContain (int windowID)
		{
				if (GUI.Button (new Rect (70, 70, 100, 20), "关闭音乐")) {
						GameObject.Find ("Terrain").GetComponent<AudioSource> ().enabled = false;
				}
				if (GUI.Button (new Rect (70, 100, 100, 20), "播放音乐")) {
						GameObject.Find ("Terrain").GetComponent<AudioSource> ().enabled = true;
				}
				if (GUI.Button (new Rect (70, 130, 100, 20), "关闭窗口")) {
						WindowSwitch = false;
				}
				if (GUI.Button (new Rect (70, 160, 100, 20), "退出游戏")) {
						Application.Quit ();
				}

				GUI.DragWindow (new Rect (0, 0, 1000, 1000));
		}

}
