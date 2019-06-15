using UnityEngine;
using System.Collections;
using System;


public class Arr : MonoBehaviour
{
		public GUIText textGUI;
		public ArrayList arr = new ArrayList ();
		public ArrayList barr = new ArrayList ();
		// Use this for initialization
		void Start ()
		{
				arr.Add (9);
				arr.Add (12);
				arr.Add (65);
				arr.Add (58);
		}
	
		// Update is called once per frame
		void Update ()
		{
				barr.Add ("push1");
				barr.Add ("push2");
				//arr.Sort ();
				textGUI.text = arr.Add (",").ToString () + " , arr 长度：" + arr.ToString ().Length + barr.ToString () + " barr 长度" + barr.ToString ().Length;
		}
}
