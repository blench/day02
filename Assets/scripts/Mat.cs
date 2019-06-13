using UnityEngine;
using System.Collections;

public class Mat : MonoBehaviour
{
		public GUITexture crossHairVar;
		public GUIText hintText;
		public GUIText scoreText;
		void OnTriggerEnter (Collider col)
		{
				if (col.gameObject.tag.Equals ("Player")) {
						CoconutThrower.canThrow = true;
						//加上准星的代码
						crossHairVar.enabled = true;
						scoreText.enabled = true;
						if (CoconutWin.haveWon == false) {
								hintText.enabled = true;
								hintText.text = "提示信息\n1、鼠标点击发射椰子\n2、同一时间段内打倒三个标靶胜利！\n3、空格跳跃获取能量\n4、点击能量盒子可以重新开始射击游戏！";
						}
				}
		}

		void OnTriggerExit (Collider col)
		{
				if (col.gameObject.tag.Equals ("Player")) {
						CoconutThrower.canThrow = false;
						crossHairVar.enabled = false;
						scoreText.enabled = false;
				}
		}
}
