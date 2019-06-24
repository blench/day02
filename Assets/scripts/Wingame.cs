using UnityEngine;
using System.Collections;

public class Wingame : MonoBehaviour
{

		public GUITexture FaderGUIVar;
		// Use this for initialization
		IEnumerator Start ()
		{
				yield return new WaitForSeconds (8.0f);
				Instantiate (FaderGUIVar);
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
}
