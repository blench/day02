using UnityEngine;
using System.Collections;

public class Tg : MonoBehaviour
{
		public Light doorLight;
		public GUIText hint;
		public AudioSource doorCloseSound;
		// Use this for initialization
		void Start ()
		{
		
		}
	
		// Update is called once per frame
		void Update ()
		{
		
		}
	
		void OnTriggerEnter (Collider col)
		{
				if (col.gameObject.tag.Equals ("Player")) {
						if (Inventory.charge == 4) {
								if (GameObject.Find ("powerGUI")) {
										Destroy (GameObject.Find ("powerGUI"));
										doorLight.color = Color.green;
								}
								transform.FindChild ("door").SendMessage ("DoorCheck");
				
						} else {
								hint.text = "这扇门需要你收集足够的能量源物体才能启动！";
								doorCloseSound.audio.Play ();
								if (!hint.enabled) {
										hint.enabled = true;
								}
								if (Time.deltaTime > 4.0) {
										hint.enabled = false;
								}
						}
				}
		
		}
}