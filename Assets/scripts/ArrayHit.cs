using UnityEngine;
using System.Collections;

public class ArrayHit : MonoBehaviour
{
		public Renderer[] cms = new Renderer[5];
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void OnControllerColliderHit (ControllerColliderHit hit)
		{
				if (hit.gameObject.name.Equals ("Cylinder")) {
						foreach (Renderer co in cms) {
								co.material.color = Color.red;
						}
				}
				if (hit.gameObject.name.Equals ("Sphere")) {
						foreach (Renderer co in cms) {
								co.material.color = Color.green;
						}
				}
				if (hit.gameObject.name.Equals ("Cube")) {
						foreach (Renderer co in cms) {
								co.material.color = Color.blue;
						}
				}
				if (hit.gameObject.name.Equals ("Capsule")) {
						foreach (Renderer co in cms) {
								co.material.color = Color.yellow;
						}
				}
		}
}
