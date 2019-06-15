using UnityEngine;
using System.Collections;

public class RotateAroundZ : MonoBehaviour
{
		public Transform cy;
		// Use this for initialization
		void Start ()
		{
			
		}
	
		// Update is called once per frame
		void Update ()
		{
				transform.RotateAround (cy.position, Vector3.up, 200 * Time.deltaTime);
		}
}
