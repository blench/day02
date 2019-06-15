using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{

		public float speed = 6.0f;
		public float jumpSpeed = 8.0f;
		public float gravity = 20.0f;
		private Vector3 moveDirection = Vector3.zero;
		private bool grounded = false;
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{

		}

		void FixedUpdate ()
		{
				if (grounded) {
						moveDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
						moveDirection = transform.InverseTransformDirection (moveDirection);
						moveDirection *= speed;

						if (Input.GetButton ("Jump")) {
								moveDirection.y = jumpSpeed;
						}
				}
				moveDirection.y -= gravity * Time.deltaTime;

				CharacterController controller = GetComponent<CharacterController> ();
//				CollisionFlags flags = controller.Move (moveDirection * Time.deltaTime);
//				grounded = (flags != null & CollisionFlags.CollidedBelow != 0);
		}
}
