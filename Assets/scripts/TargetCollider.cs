using UnityEngine;
using System.Collections;

public class TargetCollider : MonoBehaviour
{

		private bool beenHit = false;
		private Animation targetRoot;
		public AudioClip hitSound;
		public AudioClip resetSound;
		public static float resetTime = 3.0f;
		// Use this for initialization
		void Start ()
		{
				targetRoot = transform.parent.transform.parent.animation;
		}
		
		void OnCollisionEnter (Collision col)
		{
				if (beenHit == false && col.gameObject.name.Equals ("coconut")) {
						//audio.PlayOneShot (hitSound);
						StartCoroutine ("TargetHit");
						//GameObject.Find ("Terrain").GetComponent<AudioSource> ().enabled = true;
				}
		}

		IEnumerator TargetHit ()
		{
				audio.PlayOneShot (hitSound);
				targetRoot.Play ("down");
				beenHit = true;
				CoconutWin.target++;
				//暂停三秒
				yield return new WaitForSeconds (resetTime);

				audio.PlayOneShot (resetSound);
				targetRoot.Play ("up");
				beenHit = false;
				CoconutWin.target--;
		}
}
