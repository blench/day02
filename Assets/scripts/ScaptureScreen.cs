using UnityEngine;
using System.Collections;

public class ScaptureScreen : MonoBehaviour
{

		// Update is called once per frame
		void Update ()
		{
				if (Input.GetKey (KeyCode.P) && Input.GetKey (KeyCode.LeftControl)) {
						Application.CaptureScreenshot ("ScreenShot.png");
				}
		}
}
