using UnityEngine;
using System.Collections;

public class Rj : MonoBehaviour
{

		public float t = 0;
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				t += Time.deltaTime;
				if (t > 0 && t <= 2) {
						renderer.material.color = Color.blue;
				} else if (t > 2 && t <= 5) {
						renderer.material.color = Color.green;
				} else if (t > 7) {
						t = 0;
				}
		}
}
