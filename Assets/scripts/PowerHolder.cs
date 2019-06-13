using UnityEngine;
using System.Collections;

public class PowerHolder : MonoBehaviour
{
		public GUIText scoreText;
		// Use this for initialization

		void OnMouseDown ()
		{
				TargetCollider.resetTime = 3.0f;
				CoconutWin.score = 0;
				if (!scoreText.enabled) {
						scoreText.enabled = true;
				}
		}
}