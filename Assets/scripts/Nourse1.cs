using UnityEngine;
using System.Collections;

public class Nourse1 : MonoBehaviour
{

		public Color oldColor;
		public bool play = false;
		// Use this for initialization
		void Start ()
		{
				oldColor = renderer.material.color;
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void OnMouseOver ()
		{
				renderer.material.color = Color.red;
				transform.Rotate (0, 180 * Time.deltaTime, 0);
		}

		void OnMouseExit ()
		{
				renderer.material.color = oldColor;
		}
	
		void OnMouseDown ()
		{
				if (!play) {
						audio.Play ();
						play = true;
				} else {
						audio.Pause ();
						play = false;
				}
		}
}
