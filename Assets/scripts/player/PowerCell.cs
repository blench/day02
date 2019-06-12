using UnityEngine;
using System.Collections;

public class PowerCell : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				transform.Rotate (0, 100 * Time.deltaTime, 0);
		}

		void OnTriggerEnter (Collider col)
		{
				if (col.gameObject.tag.Equals ("Player")) {
						col.gameObject.SendMessage ("CellPickUp");
						Destroy (gameObject);
				}
		}
}
