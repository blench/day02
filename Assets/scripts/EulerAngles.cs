using UnityEngine;
using System.Collections;

public class EulerAngles : MonoBehaviour
{
		public Vector3 old;
		// Use this for initialization
		void Start ()
		{
				old = transform.eulerAngles;
		}
	
		// Update is called once per frame
		void OnMouseEnter ()
		{
				transform.LookAt (Inventory.player);
		}

		void OnMouseExit ()
		{
				transform.eulerAngles = old;
		}
}
