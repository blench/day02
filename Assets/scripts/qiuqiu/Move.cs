using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{

		public float Speed = 2;
		public int Dir;
		public int minnum = 1;
		public int maxnum = 5;
		Rigidbody2D rig;

		private bool CanBig;
		public int body = 10;
		// Use this for initialization
		void Start ()
		{
				CanBig = true;
				rig = GetComponent<Rigidbody2D> ();
				//rig.velocity = Vector2.right * Speed;
				Dir = Random.Range (minnum, maxnum);
				Init ();
		}
	
		// Update is called once per frame
		void Update ()
		{
				KeyCtrl ();
		}

		

		void KeyCtrl ()
		{
				if (Input.GetKeyDown (KeyCode.A)) {
						rig.velocity = -Vector2.right * Speed;
				}
				if (Input.GetKeyDown (KeyCode.D)) {
						rig.velocity = Vector2.right * Speed;
				}
				if (Input.GetKeyDown (KeyCode.W)) {
						rig.velocity = Vector2.up * Speed;
				}
				if (Input.GetKeyDown (KeyCode.D)) {
						rig.velocity = -Vector2.up * Speed;
				}
		}

		void Init ()
		{
				switch (Dir) {
				case 1:
						rig.velocity = -Vector2.right * Speed;
						break;
				case 2:
						rig.velocity = Vector2.right * Speed;
						break;
				case 3:
						rig.velocity = Vector2.up * Speed;
						break;
				case 4:
						rig.velocity = -Vector2.up * Speed;
						break;
				default:
						break;
				}
		}

		void OnTriggerEnter2D (Collider2D col)
		{
				if (col.transform.tag == "Food") {
						Destroy (col.gameObject);
						Grow ();
						body += 1;
				}
		}

		void Grow ()
		{
				if (CanBig) {
						transform.localScale += new Vector3 (0.5f, 0.5f, 0.5f);
				}

				if (body == 50) {
						CanBig = false;
				}
		}

		void OnGUI ()
		{
				GUI.Label (new Rect (Screen.width / 2, 20, 200, 20), "当前吨数：" + body);
		}
}
