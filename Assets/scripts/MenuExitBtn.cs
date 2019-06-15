using UnityEngine;
using System.Collections;

public class MenuExitBtn : MonoBehaviour
{
		public Texture2D normalTexture;
		public Texture2D rollerTexture;
		public AudioClip beep;
	
		void OnMouseEnter ()
		{
				guiTexture.texture = rollerTexture;
		}
	
		void OnMouseExit ()
		{
				guiTexture.texture = normalTexture;
		}
	
		IEnumerator  OnMouseDown ()
		{
				audio.PlayOneShot (beep);
				yield return new WaitForSeconds (0.35f);
				Application.Quit ();
		}
}
