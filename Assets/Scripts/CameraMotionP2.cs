using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;


public class CameraMotionP2 : MonoBehaviour {
	//*********************************************************************************
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
	public Camera P2;
	//**********************************************************************************
	//****************************************************
	/*
	private bool KingWhiteDead;
	private bool KingBlackDead;
	public GameObject VictoryText;
*/
	//***************************************************
	/*	
   //public Camera MC;
	public static PlayerControl control;
	private Camera PlayerCam;			// Camera used by the player
	private GameManager _GameManager2; 	// GameObject responsible for the management of the game
	private int _activePlayer;
	private bool _player1AI;
	private bool _player2AI;

	public int PlayerDat;
	public int PlayerDat1;
	public Camera P1;
	//public Camera P2;
	public Camera MC;

	*/
	//**********************************************************************************
	// Use this for initialization

	// Update is called once per frame
	void Update() {
		float xAxisValue = Input.GetAxis ("Horizontal");
		float zAxisValue = Input.GetAxis ("Vertical");
		if (Camera.current == P2) {
			Debug.Log ("It is P20");
			P2.transform.Translate (new Vector3 (xAxisValue, 0.0f, zAxisValue));
			P2.transform.position = new Vector3  (Mathf.Clamp (transform.position.x, Min_X, Max_X), 
				Mathf.Clamp (transform.position.y, Min_Y, Max_Y), Mathf.Clamp (transform.position.z, P2Min_Z, P2Max_Z));
			Debug.Log ("X Value = " + xAxisValue);
			Debug.Log ("Y Value = " + zAxisValue);
		} 
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
		//*******************************************************************************************************************************************


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
		//********************************************************************************************************************************************/
/*	_activePlayer = _GameManager2.activePlayer;
		if ((_activePlayer == 1 && _player1AI == false) || (_activePlayer == -1 && _player2AI == false)) {
			Debug.Log ("Select");
			GetMouseInputs ();
		}
		/*PlayerDat1 = GameManager.control.PlayerDATx;
		if (PlayerDat == PlayerDat1) {
			PlayerCam = P2.gameObject.GetComponent<Camera> ();
		} else {
			PlayerDat = GameManager.control.PlayerDATx;
			//finding camera from its tag...\
			if (PlayerDat == 0) {
				PlayerCam = P1.gameObject.GetComponent<Camera> (); 
			} else if (PlayerDat == 1) {
				PlayerCam = P2.gameObject.GetComponent<Camera> (); 
			} else if (PlayerDat == 2) {
				PlayerCam = MC.gameObject.GetComponent<Camera> (); 
			}
	}

	void Start () 
	{
		//PlayerCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>(); // Find the Camera's GameObject from its tag 
		PlayerCam = P2.gameObject.GetComponent<Camera>();
		_GameManager2 = gameObject.GetComponent<GameManager>();
		_player1AI = _GameManager2.player1AI;
		_player2AI = _GameManager2.player2AI;

	}
	// Detect Mouse Inputs
	void GetMouseInputs()
	{	
		_activePlayer = _GameManager2.activePlayer;
		Ray _ray;
		RaycastHit _hitInfo;

		// Select a piece if the gameState is 0 or 1
		if(_GameManager2.gameState < 2)
		{
			// On Left Click
			if(Input.GetMouseButtonDown(0))
			{
				_ray = PlayerCam.ScreenPointToRay(Input.mousePosition); // Specify the ray to be casted from the position of the mouse click

				// Raycast and verify that it collided
				if(Physics.Raycast (_ray,out _hitInfo))
				{
					// Select the piece if it has the good Tag
					if(_hitInfo.collider.gameObject.tag == (_activePlayer.ToString()))
					{

						_GameManager2.SelectPiece(_hitInfo.collider.gameObject);
					}
				}
			}
		}

		// Move the piece if the gameState is 1
		if(_GameManager2.gameState == 1)
		{
			Vector2 selectedCoord;

			// On Left Click
			if(Input.GetMouseButtonDown(0))
			{
				_ray = PlayerCam.ScreenPointToRay(Input.mousePosition); // Specify the ray to be casted from the position of the mouse click

				// Raycast and verify that it collided
				if(Physics.Raycast (_ray,out _hitInfo))
				{

					// If the ray hit a cube, move. If it hit a piece of the other player, eat it.
					if(_hitInfo.collider.gameObject.tag == ("Cube"))
					{
						selectedCoord = new Vector2(_hitInfo.collider.gameObject.transform.position.x,_hitInfo.collider.gameObject.transform.position.z);
						_GameManager2.MovePiece(selectedCoord);
					}
					else if(_hitInfo.collider.gameObject.tag == ((-1*_activePlayer).ToString()))
					{
						_GameManager2.EatPiece(_hitInfo.collider.gameObject);
					}
				}
			}	
		}*/
	}
}

