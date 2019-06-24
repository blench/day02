using UnityEngine;
using System.Collections;

public class NetworkServer : MonoBehaviour
{

		private string Roip = "127.0.0.1";
		private int Rport = 10000;
		private int Coconut = 15;
		private bool Usenat = false;
		// Use this for initialization
		void OnGUI ()
		{
				switch (Network.peerType) {
				case NetworkPeerType.Disconnected:
						StartServer ();
						break;
				case NetworkPeerType.Server:
						OnServer ();
						break;
				case NetworkPeerType.Connecting:
						Debug.Log ("连接中");
						break;
				}
		}

		void StartServer ()
		{
				Roip = GUI.TextField (new Rect (10, 30, 100, 20), Roip);
				if (GUI.Button (new Rect (10, 50, 100, 30), "创建服务器")) {
						Network.incomingPassword = "unitynetwork";
						// 自动服务器
						NetworkConnectionError Error = Network.InitializeServer (Coconut, Rport, Usenat);
						Debug.Log (Error);
				}
		}

		void OnServer ()
		{
				GUILayout.Label ("创建服务器成功！等待连接。。。");
				string IP = Network.player.ipAddress;
				int Port = Network.player.port;
				GUILayout.Label ("IP地址：" + IP + "\n 端口：" + Port);
				int ConnectLength = Network.connections.Length;
				for (int i = 0; i < ConnectLength; i ++) {
						GUILayout.Label ("连接的 IP ： " + Network.connections [i].ipAddress);
				}

				if (GUI.Button (new Rect (10, 100, 100, 30), "断开连接")) {
						Network.Disconnect (200);
				}
		}
}
