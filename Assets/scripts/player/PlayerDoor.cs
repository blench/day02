using UnityEngine;
using System.Collections;

public class PlayerDoor : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				RaycastHit hit = new RaycastHit ();
				if (Physics.Raycast (transform.position, transform.forward, out hit, 3.0f)) {
						if (!hit.collider.gameObject.tag.Equals ("playerDoor")) {
								GameObject currentDoor = hit.collider.gameObject;
								currentDoor.SendMessage ("DoorCheck");

						}
				}
		}
}
