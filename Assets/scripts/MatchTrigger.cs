using UnityEngine;
using System.Collections;

/**
 * 触发捡火柴
 * **/
public class MatchTrigger : MonoBehaviour
{
		void OnTriggerEnter (Collider col)
		{
				if (col.gameObject.tag.Equals ("Player")) {
						col.gameObject.SendMessage ("MatchPickUp");
						Destroy (gameObject);
				}
		}
}
