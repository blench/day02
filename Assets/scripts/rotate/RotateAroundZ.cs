using UnityEngine;
using System.Collections;

public class RotateAroundZ : MonoBehaviour
{
		public Transform cy;
		// Use this for initialization
		void Start ()
		{
			
		}
	
		// Update is called once per frame
		//在某些英雄的技能中使用旋转可以
		void Update ()
		{
				transform.RotateAround (cy.position, Vector3.up, 200 * Time.deltaTime);
		}
}
