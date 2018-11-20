using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	//public static PlayerControl control;
	private Camera PlayerCam;			// Camera used by the player
	private GameManager _GameManager; 	// GameObject responsible for the management of the game
	private int _activePlayer;
	private bool _player1AI;
	private bool _player2AI;

	public int PlayerDat;
	public int PlayerDat1;
	public Camera P1;
	public Camera P2;
	public Camera MC;

	/*void awake(){
		//PlayerDat = GameManager.control.PlayerDATx;
		/*if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this;
		}
		else if (control != this){
			Destroy(gameObject);
		}*/
	//}*/
	// Use this for initialization
	void Start () 
	{
		//PlayerCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>(); // Find the Camera's GameObject from its tag 
		PlayerCam = MC.gameObject.GetComponent<Camera>();
		_GameManager = gameObject.GetComponent<GameManager>();
		_player1AI = _GameManager.player1AI;
		_player2AI = _GameManager.player2AI;

	}

	// Update is called once per frame
	void Update () {
		// Look for Mouse Inputs
		_activePlayer = _GameManager.activePlayer;
		if ((_activePlayer == 1 && _player1AI == false) || (_activePlayer == -1 && _player2AI == false)) {
			Debug.Log ("Select");
			GetMouseInputs ();
		}
		/*PlayerDat1 = GameManager.control.PlayerDATx;
		if (PlayerDat == PlayerDat1) {
			PlayerCam = P2.gameObject.GetComponent<Camera>();
		} else {
			PlayerDat = GameManager.control.PlayerDATx;
			//finding camera from its tag...\
			if (PlayerDat == 0) {
				PlayerCam = P1.gameObject.GetComponent<Camera>(); 
			} else if (PlayerDat == 1) {
				PlayerCam = P2.gameObject.GetComponent<Camera>(); 
			} else if (PlayerDat == 2) {
				PlayerCam = MC.gameObject.GetComponent<Camera>(); 
			}
		}*/
			
			
	}

	// Detect Mouse Inputs
	void GetMouseInputs()
	{	
		_activePlayer = _GameManager.activePlayer;
		Ray _ray;
		RaycastHit _hitInfo;

		// Select a piece if the gameState is 0 or 1
		if(_GameManager.gameState < 2)
		{
			// On Left Click
			if(Input.GetMouseButtonDown(0))
			{
				_ray = PlayerCam.ScreenPointToRay(Input.mousePosition); // Specify the ray to be casted from the position of the mouse click

				// Raycast and verify that it collided
				if(Physics.Raycast (_ray,out _hitInfo))
				{
					// Select the piece if it has the good Tag
					if (_hitInfo.collider.gameObject.tag == (_activePlayer.ToString ())) {

						_GameManager.SelectPiece (_hitInfo.collider.gameObject);
						Debug.Log (_hitInfo.collider.gameObject);
					} else if (_activePlayer == 1) {
						if (_hitInfo.collider.gameObject.tag == ("KingWhite")) {

							_GameManager.SelectPiece (_hitInfo.collider.gameObject);
							Debug.Log (_hitInfo.collider.gameObject);
						}
					} else if (_activePlayer == -1) {
						if (_hitInfo.collider.gameObject.tag == ("KingBlack")) {

							_GameManager.SelectPiece (_hitInfo.collider.gameObject);
							Debug.Log (_hitInfo.collider.gameObject);
						}
					}
				}
			}
		}

		// Move the piece if the gameState is 1
		if(_GameManager.gameState == 1)
		{
			Vector2 selectedCoord;

			// On Left Click
			if(Input.GetMouseButtonDown(0))
			{
				_ray = PlayerCam.ScreenPointToRay(Input.mousePosition); // Specify the ray to be casted from the position of the mouse click

				// Raycast and verify that it collided
				if (Physics.Raycast (_ray, out _hitInfo)) {
					int Checker;
					//selectedCoord = new Vector2 (_hitInfo.collider.gameObject.transform.position.x, _hitInfo.collider.gameObject.transform.position.z);
					if (_hitInfo.collider.gameObject.tag == ((-1 * _activePlayer).ToString ())) {
						_GameManager.EatPiece (_hitInfo.collider.gameObject);
						Checker = 1;
					} else if (_hitInfo.collider.gameObject.tag == "KingWhite") {
						Debug.Log ("killing the king!! White!!");
						_GameManager.EatPiece (_hitInfo.collider.gameObject);
						Checker = 1;
					} else if (_hitInfo.collider.gameObject.tag == "KingBlack") {
						Debug.Log ("killing the king!! Black!!");
						_GameManager.EatPiece (_hitInfo.collider.gameObject);
						Checker = 1;
					}
					
					// If the ray hit a cube, move. If it hit a piece of the other player, eat it.
					if (_hitInfo.collider.gameObject.tag == ("Cube")) {
							selectedCoord = new Vector2 (_hitInfo.collider.gameObject.transform.position.x, _hitInfo.collider.gameObject.transform.position.z);
							_GameManager.MovePiece (selectedCoord);
							_GameManager._movementLegalBool = false;
					} 
							
				}
			}	
		}
	}
}
