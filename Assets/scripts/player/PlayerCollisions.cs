using UnityEngine;
using System.Collections;

public class PlayerCollisions : MonoBehaviour
{		/*
		private bool doorIsOpen = false;
		public GameObject currentDoor;
		public float doorTimer = 0.0f;

		public float doorOpenTime = 3.0f;
		public AudioClip doorOpenSound;
		public AudioClip doorShutSound;

		public GUIText hintText = new GUIText ();
		public float hintTime = 0.0f;
		// Update is called once per frame

		void Update ()
		{
				if (doorIsOpen) {
						doorTimer += Time.deltaTime;
						if (doorTimer > doorOpenTime) {
								door (false, doorShutSound, "closeDoor", currentDoor);
								doorTimer = 0.0f;
						}
				}

				if (hintText.enabled) {
						hintTime += Time.deltaTime;
						if (hintTime > 4.0) {
								hintText.enabled = false;
								hintTime = 0.0f;
						}
				}

		}

		public void OnControllerColliderHit (ControllerColliderHit hit)
		{
				if (hit.gameObject.tag == "playerDoor" && doorIsOpen == false) {
						this.currentDoor = hit.gameObject;
						//openDoor (hit.gameObject);
						door (true, doorOpenSound, "openDoor", currentDoor);
				}
		}

		public void door (bool doorCheck, AudioClip aClip, string animName, GameObject thisDoor)
		{
				doorIsOpen = doorCheck;
				thisDoor.audio.PlayOneShot (aClip);
				thisDoor.transform.parent.animation.Play (animName);

		}
		
		void DoorCheck ()
		{
				if (!doorIsOpen) {
						door (true, doorOpenSound, "openDoor", currentDoor);
				}
		}*/
		
		public bool campFire = false;
		public GameObject smokeVar;
		public GameObject fireVar;
		public GUIText collectHelpText;
		private float displayTime = 0.0f;
		
		void Update ()
		{
				RaycastHit hit = new RaycastHit ();
				displayTime += Time.deltaTime;
				if (Physics.Raycast (transform.position, transform.forward, out hit, 3)) {
						if (hit.collider.gameObject.tag.Equals ("playerDoor")) {
								GameObject currentDoor = hit.collider.gameObject;
								currentDoor.SendMessage ("DoorCheck");
						}
				}
		}
		
		void OnControllerColliderHit (ControllerColliderHit hit)
		{
				if (hit.gameObject.tag.Equals ("campFire") && Inventory.hasMatch && !campFire) {
						smokeVar.renderer.enabled = true;
						fireVar.renderer.enabled = true;
						campFire = true;
						hit.gameObject.audio.Play ();
				}

				if (hit.gameObject.tag.Equals ("campFire") && !Inventory.hasMatch && !campFire) {
						collectHelpText.enabled = true;
						collectHelpText.text = "你还没有收集火柴，请先去小屋收集火柴再来点燃篝火！";
				}
		}
}
