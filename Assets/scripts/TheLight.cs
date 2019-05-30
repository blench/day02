using UnityEngine;
using System.Collections;

public class TheLight : MonoBehaviour
{

		public Light theLight;
		public GUIText theText;
		public GameObject theCube1;
		// Use this for initialization
		void Start ()
		{
				theLight = (Light)GameObject.Find ("Spotlight").GetComponent<Light> ();
				theText = (GUIText)GameObject.Find ("wenzi").GetComponent<GUIText> ();
				theCube1 = GameObject.Find ("Cube1");
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetKey (KeyCode.L)) {
						theLight.GetComponent<Light> ().intensity += 0.1f;
						theText.GetComponent<GUIText> ().text = "当前亮度为" + theLight.GetComponent<Light> ().intensity;
				}
				if (Input.GetKey (KeyCode.K)) {
						theLight.GetComponent<Light> ().intensity -= 0.1f;
						theText.GetComponent<GUIText> ().text = "当前亮度为" + theLight.GetComponent<Light> ().intensity;
				}
				if (Input.GetKey (KeyCode.S)) {
						theCube1.SendMessage ("Start");
				}
		}
}
