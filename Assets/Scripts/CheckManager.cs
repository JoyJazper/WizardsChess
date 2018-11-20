using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckManager : MonoBehaviour {


	//public GameObject WhiteKing;
	//public GameObject BlackKing;
	//public GameObject VictoryText;
	//public bool KingWhiteDead;
	//public bool KingBlackDead;
	//public GameObject[] Go1;
	//public GameObject[] Go2;
	//public GameObject WinningPanel;
	// Use this for initialization
	void Start () {
		//WinningPanel = GameObject.FindGameObjectWithTag ("WinningPanel");
		//WinningPanel.gameObject.SetActive (false);
		//WhiteKing = GameObject.FindGameObjectWithTag ("KingWhite");
		//BlackKing = GameObject.FindGameObjectWithTag ("KingBlack");
	}
/*	
	// Update is called once per frame
	void update()
	{
		Debug.Log ("into update!!");

		WinningPanel.gameObject.SetActive (false);

		if (WhiteKing == null && BlackKing != null) {
			WinningPanel.gameObject.SetActive (true);
			Debug.Log("into 1WnBm");
			//WinningPanel1.gameObject.SetActive (true);
			//WinningPanel2.gameObject.SetActive (true);
			foreach (GameObject Go in Go2) {
				Go.SetActive (true);
			}
			KingWhiteDead = true;

		} else if (BlackKing == null && WhiteKing != null) {
			WinningPanel.gameObject.SetActive (true);
			Debug.Log("into 1WmBn");
			//WinningPanel1.gameObject.SetActive (true);
			//WinningPanel2.gameObject.SetActive (true);
			foreach (GameObject Ge in Go1) {
				Ge.SetActive (true);
			}
			KingBlackDead = true;
		} else {
			WinningPanel.gameObject.SetActive (false);
			//WinningPanel1.gameObject.SetActive (false);
			//WinningPanel2.gameObject.SetActive (false);
			KingWhiteDead = false;
			KingBlackDead = false;

		}

		if ((PlayerDATx == 0) && (SetMC == false)) {
			P1.GetComponent<Camera>().enabled = true;
			P2.GetComponent<Camera>().enabled = false;
			MC.GetComponent<Camera>().enabled = false;
		} else if((PlayerDATx == 1) && (SetMC == false) ){
			P1.GetComponent<Camera>().enabled = false;
			P2.GetComponent<Camera>().enabled = true;
			MC.GetComponent<Camera>().enabled = false;
		}
		else if(SetMC == true) {
			MC.GetComponent<Camera>().enabled = true;
			P1.GetComponent<Camera>().enabled = false;
			P2.GetComponent<Camera>().enabled = false;
		}

	//}
		*/
}
