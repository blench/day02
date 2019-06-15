using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour
{

		public static int charge = 0;
		public AudioClip collectSound;
		public Texture2D[] textures = new Texture2D[5];
		public GUITexture powerGUI;
		public Texture2D[] mainTextures = new Texture2D[5];
		public Renderer chargemeter;
		public GUITexture matchHintText;
		public AudioClip matchSound;
		public static bool hasMatch = false;
		public static Transform player ;
		// Use this for initialization
		void Start ()
		{
				charge = 0;
		}
		
		void Update ()
		{
				//Transform tran = Transform.Instantiate (player, transform.position, transform.rotation);
		}
		// Update is called once per frame电池拾取函数
		void CellPickUp ()
		{
				if (!powerGUI.enabled) {
						powerGUI.enabled = true;
				}
				AudioSource.PlayClipAtPoint (collectSound, transform.position);
				charge++;
				powerGUI.texture = textures [charge];
				chargemeter.material.mainTexture = mainTextures [charge];
		}

		//火柴拾取函数
		void MatchPickUp ()
		{
				if (!matchHintText.enabled) {
						matchHintText.enabled = true;
				}
				AudioSource.PlayClipAtPoint (matchSound, transform.position);
				hasMatch = true;
		}
}
