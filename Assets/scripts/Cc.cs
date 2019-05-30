using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Rigidbody))]

public class Cc : MonoBehaviour
{

		public float moveSpeed = 5.0f;
		float blastMoveSpeed;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				blastMoveSpeed = moveSpeed * 2.0f;
				Vector3 sudu = new Vector3 (0, blastMoveSpeed, 0);
				rigidbody.velocity = sudu;
		}
}
