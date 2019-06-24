using UnityEngine;
using System.Collections;

public class Animation01 : MonoBehaviour
{

		public float XstartPosition = 0.0f;
		public float XendPosition = 0.0f;
		public float Speed = 1.0f;
		private float StartTime = 0.0f;
		// Use this for initialization
		void Start ()
		{
				StartTime = Time.time;
		}
	
		// Update is called once per frame
		void Update ()
		{
				transform.position = new Vector3 (Mathf.Lerp (XstartPosition, XendPosition, (Time.time - StartTime) * Speed), 0, 0);
		}
}
