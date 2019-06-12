using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour
{

		public static int charge = 0;
		public AudioClip collectSound = new AudioClip ();
		public Texture2D[] textures = new Texture2D[5];
		public GUITexture powerGUI = new GUITexture ();
		public Texture2D[] mainTextures = new Texture2D[5];
		public Renderer chargemeter;
		// Use this for initialization
		void Start ()
		{
				charge = 0;
		}
	
		// Update is called once per frame
		void CellPickUp ()
		{
				AudioSource.PlayClipAtPoint (collectSound, transform.position);
				charge++;
				powerGUI.texture = textures [charge];
				chargemeter.material.mainTexture = mainTextures [charge];
		}
}
