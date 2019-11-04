using UnityEngine;
using System.Collections;

public class RandomColor : MonoBehaviour
{

		SpriteRenderer sp;

		public Color[] FoodColor;
		// Use this for initialization
		//随机生成一个"带有"的食物
		void Start ()
		{
				sp = GetComponent<SpriteRenderer> ();
				int randomNum = Random.Range (0, FoodColor.Length);
				sp.color = FoodColor [randomNum];
				//sp.color = Color.white;
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
}
