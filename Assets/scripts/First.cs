using UnityEngine;
using System.Collections;

public class First : MonoBehaviour
{

		public float speed = 0.5f;
		public float cc1 = 0.05f;
		string s = "我是字符型数据";
		bool b = true;
		public Vector3 v;
		// Use this for initialization
		void Start ()
		{
			
		}
	
		// Update is called once per frame
		void Update ()
		{
				v = new Vector3 (0, 0, speed);
		}
}
