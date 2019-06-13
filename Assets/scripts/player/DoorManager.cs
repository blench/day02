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
	
		void Update ()
		{
				if (doorIsOpen) {
						doorTimer += Time.deltaTime;
						if (doorTimer > doorOpenTime) {
								door (false, doorShutSound, "closeDoor");
								doorTimer = 0.0f;
						}
				}
		
				if (hintText.enabled) {
						hintTime += Time.deltaTime;
						if (hintTime > 8.0f) {
								hintText.enabled = false;
								hintTime = 0.0f;
						}
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

}
