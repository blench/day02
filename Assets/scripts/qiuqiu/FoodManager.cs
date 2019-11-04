using UnityEngine;
using System.Collections;

public class FoodManager : MonoBehaviour
{

		public GameObject Food;
		public GameObject Jiancha;

		public int Xmin = -12;
		public int Xmax = 12;
		public int Ymin = -12;
		public int Ymax = 12;
		// Use this for initialization
		void Start ()
		{
				InvokeRepeating ("GenerateFood", 0, 0.2f); //调用生成食物函数
				InvokeRepeating ("SCJC", 0, 3f);
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		// 生成食物
		public void GenerateFood ()
		{
				float x = Random.Range (Xmin, Xmax);
				float y = Random.Range (Ymin, Ymax);

				Instantiate (Food, new Vector3 (x, y, 0), Quaternion.identity);
		}

	
		public void SCJC ()
		{
				float x = Random.Range (Xmin, Xmax);
				float y = Random.Range (Ymin, Ymax);
		
				Instantiate (Jiancha, new Vector3 (x, y, 0), Quaternion.identity);
		}
}
