using UnityEngine;
using System.Collections;

public class CoconutThrower : MonoBehaviour
{
		public AudioClip throwSound;
		public Rigidbody coconutVar;
		public static bool canThrow = false;
		// Use this for initialization
		void Start ()
		{
				
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetButtonDown ("Fire1") && canThrow) {
						audio.PlayOneShot (throwSound);
						Rigidbody newRigidbody = Instantiate (coconutVar, transform.position, transform.rotation) as Rigidbody;
						newRigidbody.velocity = transform.forward * 40.0f;
						newRigidbody.name = "coconut";
						//Physics.IgnoreCollision (coconutShyVar.collider, newRigidbody.collider, true);
						//忽视碰撞
						Physics.IgnoreCollision (transform.root.collider, newRigidbody.collider, true);
				}
		}
}
