using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMotionMC : MonoBehaviour {

	public float Min_X = -2f ;
	public float Max_X = 9f;	
	public float Min_Y = 4f;
	public float Max_Y = 7f;
	public float P2Min_Z = 7f ;
	public float P2Max_Z = 14f;
	public float P1Min_Z = 2f;
	public float P1Max_Z = -5f;
	public float MCMin_Z = 0f;
	public float MCMax_Z = 7f;


	//public Camera P1;
	//public Camera P2;
	public Camera MC;

	//****************************************************
	/*
	private bool KingWhiteDead;
	private bool KingBlackDead;
	public GameObject VictoryText;
*/
	//***************************************************
	// Use this for initialization
	void Start () {

	}



	// Update is called once per frame
	void Update() {
		float xAxisValue = Input.GetAxis ("Horizontal");
		float zAxisValue = Input.GetAxis ("Vertical");
		if (Camera.current == MC) {
				Debug.Log ("It is MainCamera");
			MC.transform.Translate (new Vector3 (xAxisValue, zAxisValue, zAxisValue));
			MC.transform.position = new Vector3  (Mathf.Clamp (transform.position.x, Min_X, Max_X),Mathf.Clamp(transform.position.y,10f,10f), Mathf.Clamp (transform.position.z, MCMin_Z, MCMax_Z));
				Debug.Log ("X Value = " + xAxisValue);
				Debug.Log ("Y Value = " + zAxisValue);
			}
	
		/*//**************************************************************************************************************
		KingWhiteDead = GameManager.control.KingWhiteDead;
		KingBlackDead = GameManager.control.KingBlackDead;
		if (KingWhiteDead == true) {
			VictoryText = GameObject.FindGameObjectWithTag ("BlackWinText");
			VictoryText.gameObject.GetComponent<Text> ().enabled = true;
		} else if (KingBlackDead == true) {
			VictoryText = GameObject.FindGameObjectWithTag ("WhiteWinText");
			VictoryText.gameObject.GetComponent<Text> ().enabled = true;
		}
		//**************************************************************************************************************
*/

		/*if (Input.GetButton ("up")) {
			Debug.Log ("w key was pressed");
			P2.gameObject.transform.position += Vector3.forward * Time.deltaTime;
			transform.position = new Vector3 (Mathf.Clamp (transform.position.x, Min_X, Max_X), 
				Mathf.Clamp (transform.position.y, Min_Y, Max_Y), Mathf.Clamp (transform.position.z, P2Min_Z, P2Max_Z));
		} else if (Input.GetButton ("down")) {
			Debug.Log ("s key was pressed");
			P2.gameObject.transform.position += Vector3.back * Time.deltaTime;
			transform.position = new Vector3 (Mathf.Clamp (transform.position.x, Min_X, Max_X),
				Mathf.Clamp (transform.position.y, Min_Y, Max_Y), Mathf.Clamp (transform.position.z, P2Min_Z, P2Max_Z));
		} else if (Input.GetButton ("left")) {
			Debug.Log ("a key was pressed");
			P2.gameObject.transform.position += Vector3.left * Time.deltaTime;
			transform.position = new Vector3 (Mathf.Clamp (transform.position.x, Min_X, Max_X), 
				Mathf.Clamp (transform.position.y, Min_Y, Max_Y), Mathf.Clamp (transform.position.z, P2Min_Z, P2Max_Z));
		} else
		if (Input.GetButton("right")) {
			Debug.Log ("d key was pressed");
			P2.gameObject.transform.position += Vector3.right * Time.deltaTime;
			transform.position = new Vector3 (Mathf.Clamp (transform.position.x, Min_X, Max_X), 
				Mathf.Clamp (transform.position.y, Min_Y, Max_Y), Mathf.Clamp (transform.position.z, P2Min_Z, P2Max_Z));
		}*/

	}


}


