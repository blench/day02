using UnityEngine;
using System.Collections;

public class PlayerCollisions : MonoBehaviour
{
		private bool doorIsOpen = false;
		private GameObject currentDoor;
		private float doorTimer = 0.0f;

		private float doorOpenTime = 3.0f;
		private AudioClip doorOpenSound;
		private AudioClip doorShutSound;
	
		// Update is called once per frame
		void Update ()
		{
				if (doorIsOpen) {
						doorTimer += Time.deltaTime;
						if (doorTimer > doorOpenTime) {
								door (false, doorShutSound, "shutDoor", currentDoor);
								doorTimer = 0.0f;
						}
				}
		}

		public void OnControllerColliderHit (ControllerColliderHit hit)
		{
				if (hit.gameObject.tag == "playerDoor" && doorIsOpen == false) {
						currentDoor = hit.gameObject;
						//openDoor (hit.gameObject);
						door (true, doorOpenSound, "openDoor", currentDoor);
				}
		}

		public void openDoor (GameObject door)
		{
				doorIsOpen = true;
				door.audio.PlayOneShot (doorOpenSound);
				door.transform.parent.animation.Play ("openDoor");
		}

		public void shutDoor (GameObject door)
		{
				doorIsOpen = false;
				door.audio.PlayOneShot (doorOpenSound);
				door.transform.parent.animation.Play ("shutDoor");
		}

		public void door (bool doorCheck, AudioClip aClip, string animName, GameObject thisDoor)
		{
				doorIsOpen = doorCheck;
				thisDoor.audio.PlayOneShot (aClip);
				thisDoor.transform.parent.animation.Play (animName);

		}
}
