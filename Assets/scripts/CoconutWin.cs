using UnityEngine;
using System.Collections;

public class CoconutWin : MonoBehaviour
{
		public static int target = 0;
		public static bool haveWon = false;
		public AudioClip winSound;
		public GameObject cellPrefab;
		public static int score = 0;
		public GUIText scoreText;
		public float threeDownVar = 0.0f;
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (score >= 1000 && haveWon == false) {
						//target = 0;
						audio.PlayOneShot (winSound);
						GameObject winCell = transform.FindChild ("powerCell").gameObject;
						winCell.transform.Translate (-1, 0, 0);
						Instantiate (cellPrefab, winCell.transform.position, transform.rotation);
						Destroy (winCell);
						haveWon = true;
				}

				
				if (target == 3) {
						threeDownVar += Time.deltaTime;
						if (threeDownVar > 0.4f) {
								TargetCollider.resetTime -= 0.2f;
								score += 100;
								threeDownVar = 0;
						}
						/*优化代码，减少开销*/
						scoreText.text = "得分：" + score;
				}
		}
}
